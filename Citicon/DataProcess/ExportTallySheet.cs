using Citicon.Data;
using System;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;

namespace Citicon.DataProcess
{
    internal sealed class ExportTallySheet : ExportExcelBase
    {
        public ExportTallySheet(TallySheetReport tallySheet)
        {
            TallySheet = tallySheet ?? throw new ArgumentNullException(nameof(tallySheet));
            Template = ConfigurationManager.AppSettings["TallySheetReport.Template"];
            SaveDirectory = ConfigurationManager.AppSettings["TallySheetReport.SaveDirectory"];
            FilePath = Path.Combine(SaveDirectory, string.Format("{0:yyyy-MM-dd}_{1:yyyy-MM-dd-HH-mm-ss}.xlsx", tallySheet.DeliveryDate, DateTime.Now));
        }

        private TallySheetReport TallySheet;
        private string Template;
        private string SaveDirectory;

        public override void Dispose()
        {
            TallySheet = null;
            Template = null;
            SaveDirectory = null;
            base.Dispose();
        }

        public string FilePath { get; }

        public override void Execute()
        {
            if (!File.Exists(Template))
            {
                throw new FileNotFoundException("Template file is missing.");
            }

            if (!Directory.Exists(SaveDirectory))
            {
                Directory.CreateDirectory(SaveDirectory);
            }

            Application = new Excel.Application();
            Workbooks = Application.Workbooks;
            Workbook = Workbooks.Open(Template);
            Sheets = Workbook.Sheets;
            Worksheet = Sheets[1];

            Worksheet.Cells[2, 3] = TallySheet.Dispatcher;
            Worksheet.Cells[2, 7] = TallySheet.DeliveryDate;

            int rowCounter = 4;
            int blockStart = 1;
            int blockEnd = 9;

            int tallySheetStart = 0;
            int tallySheetEnd = 0;

            foreach (var item in TallySheet.Items)
            {
                if (item != null)
                {
                    tallySheetStart = rowCounter;

                    var itemHeaderBuilder = new StringBuilder();
                    var project = item.ProjectDesign?.Project;
                    var client = item.ProjectDesign?.Project?.Client;
                    var projectDesign = item.ProjectDesign;
                    var projectLocation = item.ProjectDesign?.Project?.Location;

                    var hasProject = project != null;
                    var hasClient = client != null;
                    var hasProjectDesign = projectDesign != null;
                    var hasProjectLocation = !string.IsNullOrWhiteSpace(projectLocation);

                    if (hasProject)
                    {
                        itemHeaderBuilder.Append(project);

                        if (hasClient || hasProjectDesign || hasProjectLocation)
                        {
                            itemHeaderBuilder.Append(" | ");
                        }
                    }

                    if (hasClient)
                    {
                        itemHeaderBuilder.Append(client);

                        if (hasProjectDesign || hasProjectLocation)
                        {
                            itemHeaderBuilder.Append(" | ");
                        }
                    }

                    if (hasProjectDesign)
                    {
                        itemHeaderBuilder.Append(projectDesign);

                        if (hasProjectLocation)
                        {
                            itemHeaderBuilder.Append(" | ");
                        }
                    }

                    if (hasProjectLocation)
                    {
                        itemHeaderBuilder.Append(projectLocation);
                    }

                    Excel.Range range = Worksheet.Range[Worksheet.Cells[rowCounter, blockStart], Worksheet.Cells[rowCounter, blockEnd]];
                    range.Merge();
                    range.Value = itemHeaderBuilder.ToString();
                    BorderAround(range);

                    rowCounter++;

                    if (item.Deliveries != null && item.Deliveries.Any())
                    {
                        var deliveryStart = rowCounter;

                        foreach (var delivery in item.Deliveries)
                        {
                            Worksheet.Cells[rowCounter, 1] = delivery.Load;
                            Worksheet.Cells[rowCounter, 2] = delivery.DeliveryReceiptNumber;
                            Worksheet.Cells[rowCounter, 3] = delivery.TransitMixer?.PhysicalNumber;
                            Worksheet.Cells[rowCounter, 4] = delivery.Driver?.ToString();
                            Worksheet.Cells[rowCounter, 5] = delivery.PlantLeave;
                            Worksheet.Cells[rowCounter, 6] = delivery.PlantArrive;
                            Worksheet.Cells[rowCounter, 7] = delivery.Volume;
                            Worksheet.Cells[rowCounter, 8] = string.Format("=H{0}+G{1}", rowCounter - 1, rowCounter);
                            Worksheet.Cells[rowCounter, 9] = delivery.ServiceEngineer?.ToString();
                            rowCounter++;
                        }

                        var deliveryEnd = rowCounter - 1;

                        for (int i = 1; i <= 9; i++)
                        {
                            BorderAround(Worksheet.Range[Worksheet.Cells[deliveryStart, i], Worksheet.Cells[deliveryEnd, i]]);
                        }
                    }

                    tallySheetEnd = rowCounter;

                    //BorderAround(Worksheet.Range[Worksheet.Cells[tallySheetStart, blockStart], Worksheet.Cells[tallySheetEnd, blockEnd]]);

                    //rowCounter++;
                }
            }

            Workbook.SaveAs(FilePath);
            PrintOption = ExportExcelPrintOption.Workbook;
            base.Execute();
        }

        private void BorderAround(Excel.Range range)
        {
            range.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
            range.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
            range.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
            range.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
        }
    }
}
