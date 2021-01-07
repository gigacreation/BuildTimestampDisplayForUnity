using System;
using System.Globalization;
using UnityEngine;

namespace BuildTimestampDisplay
{
    public class BuildTimestamp : ScriptableObject
    {
        public int utcYear;
        public int utcMonth;
        public int utcDay;
        public int utcHour;
        public int utcMinute;
        public int utcSecond;

        public override string ToString()
        {
            return new DateTime(utcYear, utcMonth, utcDay, utcHour, utcMinute, utcSecond)
                .ToString(CultureInfo.CurrentCulture);
        }

        public string ToString(string format, float utcOffsetHours)
        {
            return new DateTime(utcYear, utcMonth, utcDay, utcHour, utcMinute, utcSecond)
                .AddMinutes(Mathf.RoundToInt(utcOffsetHours * 60f))
                .ToString(format);
        }
    }
}
