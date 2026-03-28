using System;

namespace Datas
{
    public class DateCalculator
    {
        public DateTime AddDays(DateTime startDate, int days)
        {
            return startDate.AddDays(days);
        }

        public int CalculateDifference(DateTime startDate, DateTime endDate)
        {
            return Math.Abs((endDate - startDate).Days);
        }
    }
}
