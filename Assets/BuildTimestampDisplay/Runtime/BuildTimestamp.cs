using System;
using System.Globalization;
using UnityEngine;

namespace BuildTimestampDisplay
{
    public class BuildTimestamp : ScriptableObject
    {
        public int UtcYear;
        public int UtcMonth;
        public int UtcDay;
        public int UtcHour;
        public int UtcMinute;
        public int UtcSecond;

        public override string ToString()
        {
            return new DateTime(UtcYear, UtcMonth, UtcDay, UtcHour, UtcMinute, UtcSecond)
                .ToString(CultureInfo.CurrentCulture);
        }

        public string ToString(string format, double utcOffsetHours)
        {
            return new DateTime(UtcYear, UtcMonth, UtcDay, UtcHour, UtcMinute, UtcSecond)
                .AddHours(utcOffsetHours)
                .ToString(format);
        }
    }
}
