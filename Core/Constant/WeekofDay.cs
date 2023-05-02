using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Constant
{
    public static class WeekofDay
    {
        public static int weekNow = (DateTime.Now.DayOfYear-2)/7;
        public static int weekNext = weekNow+1;
        public static string dayNow = DateTime.Now.ToShortDateString();

    }
}