using Citicon.Data;
using Citicon.Extensions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using Word = Microsoft.Office.Interop.Word;

namespace Citicon.DataProcess
{
    internal sealed class ExportBilling : IDisposable
    {
        static ExportBilling()
        {
            Template = ConfigurationManager.AppSettings.GetString("Billing.Template");
            SaveLocation = ConfigurationManager.AppSettings.GetString("Billing.SaveLocation");
            PrintAfterSave = ConfigurationManager.AppSettings.GetBoolean("Billing.PrintAfterSave");
            OpenAfterSave = ConfigurationManager.AppSettings.GetBoolean("Billing.OpenAfterSave");
            MaxFirstPageDelivery = ConfigurationManager.AppSettings.GetInt32("Billing.MaxFirstPageDelivery");
        }

        private static string Template { get; }
        private static string SaveLocation { get; }
        private static bool PrintAfterSave { get; }
        private static bool OpenAfterSave { get; }
        private static int MaxFirstPageDelivery { get; }

        private const string FIELD_CUSTOMER = "CUSTOMER";
        private const string FIELD_PROJECT = "PROJECT";
        private const string FIELD_PROJECT_LOCATION = "PROJECT_LOCATION";
        private const string FIELD_DATE = "DATE";
        private const string FIELD_BILLING_NO = "BILLING_NO";
        private const string FIELD_NOTES = "NOTES";

        private const string FORMAT_DATE = "MMM d, yyyy";
        private const string FORMAT_CURRENCY = "#,##0.00";
        private const string FORMAT_INTEGER = "#,##0";

        public ExportBilling(Billing billing, Action onExported, Action<string> onError)
        {
            Billing = billing ?? throw new ArgumentNullException(nameof(billing));
            OnExported = onExported;
            OnError = onError;
        }

        private Word.Application Application;
        private Word.Documents Documents;
        private Word.Document Document;
        private Action OnExported;
        private string FilePath;
        private Action<string> OnError;
        public Billing Billing { get; }
        public bool ReachedMaxFirstPageDelivery;

        public void Export()
        {
            if (File.Exists(Template))
            {
                try
                {
                    Application = new Word.Application();
                    Documents = Application.Documents;
                    Document = Documents.Add(Template);
                    ReachedMaxFirstPageDelivery = false;
                    WriteFields();
                    WriteGeneralDetails();
                    WriteDeliveries();

                    if (!Directory.Exists(SaveLocation))
                    {
                        Directory.CreateDirectory(SaveLocation);
                    }

                    FilePath = Path.Combine(SaveLocation, $"{Billing.BillingNo}.docx");
                    Document.SaveAs(FilePath);

                    if (PrintAfterSave)
                    {
                        if (ReachedMaxFirstPageDelivery)
                        {
                            Document.PrintOut();
                        }
                        else
                        {
                            Document.PrintOut(Pages: "1");
                        }
                    }

                    OnExported();
                }
                catch (Exception ex)
                {
                    OnError(ex.Message + Environment.NewLine + ex.StackTrace);
                }
            }
            else
            {
                OnError("Template not found.");
            }
        }

        private void WriteFields()
        {
            foreach (Word.Field field in Document.Fields)
            {
                var fieldName = TrimField(field.Result.Text);

                switch (fieldName)
                {
                    case FIELD_CUSTOMER:
                        field.Result.Text = Billing.Project?.Client?.CompanyName;
                        break;
                    case FIELD_PROJECT:
                        field.Result.Text = Billing.Project?.Name;
                        break;
                    case FIELD_PROJECT_LOCATION:
                        field.Result.Text = Billing.Project?.Location;
                        break;
                    case FIELD_DATE:
                        field.Result.Text = Billing.BillingDate.ToString(FORMAT_DATE);
                        break;
                    case FIELD_BILLING_NO:
                        field.Result.Text = Billing.BillingNo;
                        break;
                    case FIELD_NOTES:
                        field.Result.Text = Billing.Notes;
                        break;
                }
            }
        }

        private void WriteGeneralDetails()
        {
            var designs = new Dictionary<ProjectDesign, List<Delivery>>();

            foreach (var delivery in Billing.Deliveries)
            {
                if (!designs.ContainsKey(delivery.ProjectDesign))
                {
                    designs.Add(delivery.ProjectDesign, new List<Delivery>());
                }

                designs[delivery.ProjectDesign].Add(delivery);
            }

            var table = Document.Tables[2];
            var counter = 2;
            decimal totalAmount = 0;
            Word.Cell cell = null;

            if (designs.Any())
            {
                foreach (var design in designs)
                {
                    var totalVolume = design.Value.Sum(d => d.Volume);
                    var amount = design.Key.PricePerCubicMeter * totalVolume;
                    var firstDelivery = design.Value.FirstOrDefault();
                    totalAmount += amount;

                    cell = table.Cell(counter, 1);
                    cell.Range.Text = (firstDelivery?.DeliveryDate ?? DateTime.Now).ToString(FORMAT_DATE);

                    cell = table.Cell(counter, 2);
                    cell.Range.Text = design.Key.ToString();

                    cell = table.Cell(counter, 3);
                    cell.Range.Text = totalVolume.ToString(FORMAT_CURRENCY);

                    cell = table.Cell(counter, 4);
                    cell.Range.Text = design.Key.PricePerCubicMeter.ToString(FORMAT_CURRENCY);

                    cell = table.Cell(counter, 5);
                    cell.Range.Text = amount.ToString(FORMAT_CURRENCY);

                    counter++;
                }
            }

            if (Billing.PumpcreteCharges.Any())
            {
                foreach (var pumpcreteCharge in Billing.PumpcreteCharges)
                {
                    totalAmount += pumpcreteCharge.TotalAmount;

                    cell = table.Cell(counter, 1);
                    cell.Range.Text = Billing.BillingDate.ToString(FORMAT_DATE);

                    cell = table.Cell(counter, 2);
                    cell.Range.Text = pumpcreteCharge.PumpType?.Name;

                    cell = table.Cell(counter, 5);
                    cell.Range.Text = pumpcreteCharge.TotalAmount.ToString(FORMAT_CURRENCY);

                    counter++;
                }
            }

            if (Billing.ExcessPipeCharges.Any())
            {
                foreach (var excessPipeCharge in Billing.ExcessPipeCharges)
                {
                    totalAmount += excessPipeCharge.TotalAmount;

                    cell = table.Cell(counter, 1);
                    cell.Range.Text = Billing.BillingDate.ToString(FORMAT_DATE);

                    cell = table.Cell(counter, 2);
                    cell.Range.Text = excessPipeCharge.AccessoryType?.Value;

                    cell = table.Cell(counter, 5);
                    cell.Range.Text = excessPipeCharge.TotalAmount.ToString(FORMAT_CURRENCY);

                    counter++;
                }
            }

            if (Billing.OtherCharges.Any())
            {
                foreach (var otherCharge in Billing.OtherCharges)
                {
                    totalAmount += otherCharge.TotalAmount;

                    cell = table.Cell(counter, 1);
                    cell.Range.Text = Billing.BillingDate.ToString(FORMAT_DATE);

                    cell = table.Cell(counter, 2);
                    cell.Range.Text = otherCharge.Type?.Value;

                    cell = table.Cell(counter, 3);
                    cell.Range.Text = otherCharge.Unit.ToString(FORMAT_INTEGER);

                    cell = table.Cell(counter, 4);
                    cell.Range.Text = otherCharge.Amount.ToString(FORMAT_CURRENCY);

                    cell = table.Cell(counter, 5);
                    cell.Range.Text = otherCharge.TotalAmount.ToString(FORMAT_CURRENCY);

                    counter++;
                }
            }

            cell = table.Cell(counter, 5);

            var topBorder = cell.Borders[Word.WdBorderType.wdBorderTop];
            var bottomBorder = cell.Borders[Word.WdBorderType.wdBorderBottom];

            topBorder.LineStyle = Word.WdLineStyle.wdLineStyleSingle;
            bottomBorder.LineStyle = Word.WdLineStyle.wdLineStyleDouble;

            cell.Range.Text = totalAmount.ToString(FORMAT_CURRENCY);
        }

        private void WriteDeliveries()
        {
            var table = Document.Tables[3];
            var counter = 2;
            Word.Cell cell = null;
            decimal totalVolume = 0;

            if (Supports.DebugMode)
            {
                var list = new List<Delivery>(Billing.Deliveries);

                for (int i = 0; i < 5; i++)
                {
                    list.AddRange(Billing.Deliveries);
                }

                Billing.Deliveries.AddRange(list);
            }

            foreach (var delivery in Billing.Deliveries)
            {
                totalVolume += delivery.Volume;

                cell = table.Cell(counter, 1);
                cell.Range.Text = delivery.DeliveryDate.ToString(FORMAT_DATE);

                cell = table.Cell(counter, 2);
                cell.Range.Text = delivery.ProjectDesign.ToString();

                cell = table.Cell(counter, 3);
                cell.Range.Text = delivery.DeliveryReceiptNumberDisplay;

                cell = table.Cell(counter, 4);
                cell.Range.Text = delivery.Volume.ToString(FORMAT_CURRENCY);

                if (!ReachedMaxFirstPageDelivery && counter >= MaxFirstPageDelivery + 1)
                {
                    ReachedMaxFirstPageDelivery = true;
                    table = Document.Tables[5];
                    counter = 0;
                }

                if (ReachedMaxFirstPageDelivery)
                {
                    table.Rows.Add();
                }

                counter++;
            }

            cell = table.Cell(counter, 4);
            var topBorder = cell.Borders[Word.WdBorderType.wdBorderTop];
            var bottomBorder = cell.Borders[Word.WdBorderType.wdBorderBottom];

            topBorder.LineStyle = Word.WdLineStyle.wdLineStyleSingle;
            bottomBorder.LineStyle = Word.WdLineStyle.wdLineStyleDouble;

            cell.Range.Text = totalVolume.ToString(FORMAT_CURRENCY);
        }

        public void Dispose()
        {
            if (Document != null)
            {
                Document.Close();
                Marshal.ReleaseComObject(Document);
                Document = null;
            }

            if (Documents != null)
            {
                foreach (Word.Document document in Documents)
                {
                    document.Close();
                    Marshal.ReleaseComObject(document);
                }

                Documents = null;
            }

            if (Application != null)
            {
                Application.Quit();
                Marshal.ReleaseComObject(Application);
                Application = null;
            }

            if (OpenAfterSave && File.Exists(FilePath))
            {
                Process.Start(FilePath);
            }
        }

        private string TrimField(string field)
        {
            return field.TrimStart('«').TrimEnd('»');
        }
    }
}
