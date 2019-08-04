using System;

namespace SingleResponbibility
{
    public class ReportLogic
    {
        public (int profit, int tax) GetReportValuesByYear(int year)
        {
            var totalRevenue = 20;
            var tax = 0;
            var profit = 0;

            if (year == 2018)
            {
                tax = totalRevenue * 10 / 100;
                profit = totalRevenue - tax;
            }
            else if (year == 2019)
            {
                tax = totalRevenue * 12 / 100;
                profit = totalRevenue - tax;
            }

            return (profit, tax);
        }
    }
}