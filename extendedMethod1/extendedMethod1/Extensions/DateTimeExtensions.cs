using System;
using System.Globalization;

namespace extendedMethod1.Extensions
{
    static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if(duration.TotalHours < 24)
            {
                return duration.TotalHours.ToString("F2", CultureInfo.InvariantCulture) + " hours";
            }  else
            {
                return duration.TotalDays.ToString("F2", CultureInfo.InvariantCulture) + " days";
            }

        }
    }
}
