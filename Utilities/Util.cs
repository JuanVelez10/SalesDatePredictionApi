using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public static class Util
    {
        public static DateTime GetNextPredictedOrderDate(List<DateTime> dates)
        {
            var days = new  List<int>();
            for (var i = 0; i < dates.Count() - 1; i++)
            {
                TimeSpan difference = dates[i + 1] - dates[i];
                days.Add(difference.Days);
            }

            var average_days = days.Sum(x => x) / dates.Count();

            return dates.Last().AddDays(average_days);
        }

    }
}
