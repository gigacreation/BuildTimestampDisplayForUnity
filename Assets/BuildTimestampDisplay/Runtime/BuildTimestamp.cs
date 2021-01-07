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
    }
}
