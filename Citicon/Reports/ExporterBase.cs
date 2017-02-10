using System;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace Citicon.Reports
{
    public abstract class ExporterBase : IDisposable
    {
        protected Excel.Application Application;
        protected Excel.Workbooks Workbooks;
        protected Excel.Workbook Workbook;
        protected Excel.Sheets Sheets;
        protected Excel.Worksheet Worksheet;
        
        public void Dispose()
        {
            if (Worksheet != null)
            {
                Marshal.ReleaseComObject(Worksheet);
            }
            if (Sheets != null)
            {
                for (int i = 1; i <= Sheets.Count; i++)
                {
                    var sheet = Sheets[i];
                    if (sheet != null)
                    {
                        Marshal.ReleaseComObject(sheet);
                    }
                }
                Marshal.ReleaseComObject(Sheets);
            }
            if (Workbook != null)
            {
                Workbook.Close();
                Marshal.ReleaseComObject(Workbook);
            }
            if (Workbooks != null)
            {
                for (int i = 1; i <= Workbooks.Count; i++)
                {
                    var workbook = Workbooks[i];
                    if (workbook != null)
                    {
                        Marshal.ReleaseComObject(workbook);
                    }
                }
                Marshal.ReleaseComObject(Workbooks);
            }
            if (Application != null)
            {
                Application.Quit();
                Marshal.ReleaseComObject(Application);
            }
        }
    }
}
