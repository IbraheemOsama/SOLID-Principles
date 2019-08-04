using System;
using System.Text;

namespace SingleResponbibility
{
    public class ReportDisplay
    {
        public string GetDisplay(int year, int profit, int tax)
        {
            var builder = new StringBuilder();
            builder.AppendLine($"------ Report Year {year} -------");
            builder.AppendLine($"Total Profit: {profit}");
            builder.AppendLine($"Tax: {tax}");
            builder.AppendLine($"------ End of Report ------");
            return builder.ToString();
        }
    }
}