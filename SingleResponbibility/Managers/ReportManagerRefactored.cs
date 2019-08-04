using System;
using System.IO;
using System.Text;

namespace SingleResponbibility
{
    public class ReportManagerRefactored
    {
        public string GetReportByYear(int year)
        {
            try
            {
                var logic = new ReportLogic();
                var display = new ReportDisplay();

                var values = logic.GetReportValuesByYear(year);
                return display.GetDisplay(year, values.profit, values.tax);
            }
            catch (Exception ex)
            {
                Logger.Log(ex.ToString());
            }

            return string.Empty;
        }
    }
}