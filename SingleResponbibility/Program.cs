using System;

namespace SingleResponbibility
{
    class Program
    {
        static void Main(string[] args)
        {
            // Old
            // var reportManager = new ReportManager();
            // Console.WriteLine(reportManager.GetReportByYear(2018));
            // Console.WriteLine(reportManager.GetReportByYear(2019));

            Console.WriteLine("-------------------------------------------\n");
            // Refactored
            var reportManagerRefactored = new ReportManagerRefactored();
            Console.WriteLine(reportManagerRefactored.GetReportByYear(2018));
            Console.WriteLine(reportManagerRefactored.GetReportByYear(2019));
        }
    }
}
