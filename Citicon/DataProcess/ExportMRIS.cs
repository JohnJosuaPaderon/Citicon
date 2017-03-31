using Citicon.Data;
using System.Configuration;
using System.Drawing;

namespace Citicon.DataProcess
{
    internal sealed class ExportMRIS : ExportExcelBase
    {
        public ExportMRIS(MRISReport mris)
        {
            MRIS = mris;
            MRISReportTemplate = ConfigurationManager.AppSettings["MrisReportTemplateV2"];
        }

        private MRISReport MRIS { get; set; }
        private string MRISReportTemplate { get; set; }
        private string MRISReportDirectory { get; set; }

        private uint GetColumnIndex(string excelName, string fieldName)
        {
            uint.TryParse(ConfigurationManager.AppSettings[$"{excelName}.ColumnIndex[{fieldName}]"], out uint value);
            return value;
        }

        private uint MrisRowStartIndex(string fieldName)
        {
            uint.TryParse(ConfigurationManager.AppSettings[$"Mris.RowStartIndex[{fieldName}]"], out uint value);
            return value;
        }

        private uint MrisColumnIndex(string fieldName)
        {
            return GetColumnIndex("Mris", fieldName);
        }

        private uint MrisMaxCount(string fieldName)
        {
            uint.TryParse(ConfigurationManager.AppSettings[$"Mris.MaxCount[{fieldName}]"], out uint value);
            return value;
        }

        private Point MrisLocation(string field)
        {
            var raw = ConfigurationManager.AppSettings[$"Mris.Location[{field}]"];
            int x = 0, y = 0;
            var pair = raw.Split(',');
            if (pair.Length == 2)
            {
                int.TryParse(pair[0], out x);
                int.TryParse(pair[1], out y);
            }
            return new Point(x, y);
        }

        private string MrisDefault(string field)
        {
            return ConfigurationManager.AppSettings[$"Mris.Default[{field}]"];
        }

        public override void Dispose()
        {
            MRIS = null;
            MRISReportTemplate = null;
            MRISReportDirectory = null;
            base.Dispose();
        }

        public override void Execute()
        {
            PrintOption = ExportExcelPrintOption.Workbook;

            base.Execute();
        }
    }
}
