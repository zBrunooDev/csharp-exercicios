using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{

    // The extension class must be static.
    static class DateTimeExtensions
    {
        // Returns the elapsed time since the specified date until now.
        // An extension method always has "this" as its first parameter,
        // followed by the type being extended and the parameter name.
        // In this case, "thisObj" represents the current object.
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);
            if (duration.TotalHours < 24.0)
            {   
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            }
            else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
            }
        }
    }
}
