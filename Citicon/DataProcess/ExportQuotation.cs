using Citicon.Data;
using Citicon.Extensions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Citicon.DataProcess
{
    public sealed class ExportQuotationResult
    {
        public ExportQuotationResult(string filePath, string message, bool success)
        {
            FilePath = filePath;
            Message = message;
            Success = success;
        }

        public string FilePath { get; }
        public string Message { get; }
        public bool Success { get; }
    }

    public sealed class ExportQuotation : IDisposable
    {
        public enum QuotationReportTemplate
        {
            Citicon = 0,
            LexCiticoncrete = 1
        }

        private QuotationReportTemplate Template;
        private string TemplatesDirectory;
        private string TemplateFile;
        private Quotation Quotation;
        private List<ProjectDesign> ProjectDesigns;
        private Word.Application Application;
        private Word.Document Document;
        private string FilePath;
        private string SaveDirectory;
        private bool PrintAfterSave;
        private int Version;

        public ExportQuotation(QuotationReportTemplate template, string templatesDirectory, Quotation quotation, List<ProjectDesign> projectDesigns, string saveDirectory, bool printAfterSave)
        {
            Template = template;
            TemplatesDirectory = templatesDirectory;
            Quotation = quotation;
            ProjectDesigns = projectDesigns;
            TemplateFile = $@"{templatesDirectory}\{template.ToString()}.dot";
            SaveDirectory = saveDirectory;
            FilePath = $@"{saveDirectory}\{quotation.ToString()}.doc";
            Version = ConfigurationManager.AppSettings.GetInt32("Quotation.Version");
        }

        public ExportQuotationResult Export()
        {
            if (!Directory.Exists(TemplatesDirectory))
            {
                return new ExportQuotationResult(null, "Templates Directory not found", false);
            }

            if (!File.Exists(TemplateFile))
            {
                return new ExportQuotationResult(null, $"Template file not found : {TemplateFile}", false);
            }

            if (Quotation == null)
            {
                return new ExportQuotationResult(null, "No Quotation", false);
            }

            try
            {
                Application = new Word.Application();
                Document = Application.Documents.Add(TemplateFile);
                WriteField();

                switch (Version)
                {
                    case 0:
                    case 1:
                        WriteDesigns_V1();
                        break;
                }

                foreach (Word.Bookmark bookmark in Document.Bookmarks)
                {
                    if (bookmark.Name == "TermsConditions")
                    {
                        Clipboard.SetText(Quotation.NoteDetails, TextDataFormat.Rtf);
                        //bookmark.Range.Text = Quotation.NoteDetails;
                        bookmark.Range.Select();
                        bookmark.Range.Paste();
                    }
                }

                if (!Directory.Exists(SaveDirectory))
                {
                    Directory.CreateDirectory(SaveDirectory);
                }

                Document.SaveAs2(FilePath);

                if (PrintAfterSave)
                {
                    Document.PrintOut();
                }

                return new ExportQuotationResult(FilePath, "Quotation successfully saved!", true);
            }
            catch (Exception e)
            {
                return new ExportQuotationResult(null, e.Message, false);
            }
        }

        private void WriteField()
        {
            foreach (Word.Field field in Document.Fields)
            {
                var FIELD_NAME = field.Result.Text?.TrimStart('«')?.TrimEnd('»');

                switch (FIELD_NAME)
                {
                    case "QuoteDate":
                        field.Result.Text = Quotation.QuotationDate.ToString("MMMM dd, yyyy");
                        break;
                    case "QuoteNum":
                        field.Result.Text = Quotation.ToString();
                        break;
                    case "COMPANYNAME":
                        field.Result.Text = Quotation.Project?.Client?.ToString();
                        break;
                    case "CompanyAddress":
                        field.Result.Text = Quotation.Project?.Client?.Address;
                        break;
                    case "companyemail":
                        field.Result.Text = Quotation.Project?.Client?.EmailAddress;
                        break;
                    case "CompanyContactNum":
                        field.Result.Text = Quotation.Project?.Client?.ContactNumber;
                        break;
                    case "CompanyAttention":
                        field.Result.Text = $"{Quotation.Project?.Client?.Title} {Quotation.Project?.Client?.FirstName} {Quotation.Project?.Client?.LastName}";
                        break;
                    case "Project":
                        field.Result.Text = Quotation.Project?.ToString();
                        break;
                    case "Location":
                        field.Result.Text = Quotation.Project?.Location;
                        break;
                    case "AGENTNAME":
                        field.Result.Text = Quotation.Agent?.ToString();
                        break;
                    case "AgentPosition":
                        field.Result.Text = Quotation.Agent?.Position?.ToString();
                        break;
                    default:
                        break;
                }
            }
        }

        private void WriteDesigns_V1()
        {
            Word.Table table = Document.Tables[1];

            bool isCementSupplied = Quotation.Project?.Type == ProjectType.CementSupplied;
            int increment = isCementSupplied ? 1 : 0;

            if (isCementSupplied)
            {
                object remarksColumn = table.Columns[3];
                Word.Column curingTimeColumn = table.Columns[4];
                Word.Column strengthColumn = table.Columns[1];

                var col = table.Columns.Add(ref remarksColumn);
                col.Cells[1].Range.Text = "C.F.";
                col.PreferredWidth = 20F;
                curingTimeColumn.PreferredWidth = 50F;
                strengthColumn.PreferredWidth = 50F;
            }

            for (int i = 0; i < ProjectDesigns.Count; i++)
            {
                Word.Row row = table.Rows.Add();

                row.Cells[1].Range.Font.Bold = 0;
                row.Cells[1].Range.Text = ProjectDesigns[i].Psi.ToString("###0") + " PSI";

                row.Cells[2].Range.Font.Bold = 0;
                row.Cells[2].Range.Text = ProjectDesigns[i].Aggregate?.ToString();

                if (isCementSupplied)
                {
                    row.Cells[3].Range.Font.Bold = 0;
                    row.Cells[3].Range.Text = ProjectDesigns[i].CementFactor.ToString("#,##0.00");
                }

                row.Cells[3 + increment].Range.Font.Bold = 0;
                row.Cells[3 + increment].Range.Text = ProjectDesigns[i].MixType.ToString();

                row.Cells[4 + increment].Range.Font.Bold = 0;
                row.Cells[4 + increment].Range.Text = ProjectDesigns[i].Strength?.ToString();

                row.Cells[5 + increment].Range.Font.Bold = 0;
                row.Cells[5 + increment].Range.Text = "PhP " + ProjectDesigns[i].PricePerCubicMeter.ToString("#,##0.00");
            }
        }

        private void WriteDesigns_V2()
        {
            var data = new Dictionary<(decimal psi, ProductAggregate aggregate, ProjectDesignMixType mixType), Dictionary<ProductStrength, decimal>>();
            var strengthColumn = new Dictionary<ProductStrength, int>();

            foreach (ProjectDesign projectDesign in ProjectDesigns)
            {
                if (!strengthColumn.ContainsKey(projectDesign.Strength))
                {
                    strengthColumn.Add(projectDesign.Strength, strengthColumn.Values.Max() + 1);
                }

                var key = (projectDesign.Psi, projectDesign.Aggregate, projectDesign.MixType);

                if (!data.ContainsKey(key))
                {
                    data.Add(key, new Dictionary<ProductStrength, decimal>());
                }

                if (!data[key].ContainsKey(projectDesign.Strength))
                {
                    data[key].Add(projectDesign.Strength, projectDesign.PricePerCubicMeter);
                }
            }

            Word.Table table = Document.Tables[1];

            table.Columns[4].Delete();
            var cell = table.Cell(1, 4);
            var columnSplit = strengthColumn.Count as object;
            cell.Split(NumColumns: ref columnSplit);

            foreach (var item in strengthColumn)
            {
                
            }

            foreach (var item in data)
            {

            }
        }

        public void Dispose()
        {
            Document.Close();
            Application.Quit();
            Marshal.ReleaseComObject(Document);
            Marshal.ReleaseComObject(Application);
        }
    }
}