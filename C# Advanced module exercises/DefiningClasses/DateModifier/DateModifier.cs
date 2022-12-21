using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    public static class DateModifier
    {
        public static int DateDifference(string startDate, string endDate)
        {
            TimeSpan diff = DateTime.Parse(startDate) - DateTime.Parse(endDate);
            return Math.Abs(diff.Days);
        }
    }
}
