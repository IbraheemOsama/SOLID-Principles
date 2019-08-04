using System;
using System.IO;
using System.Text;

namespace SingleResponbibility
{
    public class ReportManager
    {
        public string GetReportByYear(int year)
        {
            try
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

                var builder = new StringBuilder();
                builder.AppendLine($"------ Report Year {year} -------");
                builder.AppendLine($"Total Profit: {profit}");
                builder.AppendLine($"Tax: {tax}");
                builder.AppendLine($"------ End of Report ------");

                return builder.ToString();
            }
            catch (Exception ex)
            {
                File.WriteAllText("logs.txt", ex.ToString());
            }

            return string.Empty;
        }
    }
}