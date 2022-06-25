using System;

namespace HelloWorld
{
    public static class TimeChecker
    {
        public static string TimeOfDay()
        {
            var TimeNow = DateTime.Now.TimeOfDay;
            var ts = new TimeSpan();
            if (TimeNow >= new TimeSpan(0, 0, 0) && TimeNow < new TimeSpan(12, 0, 0))
                return "Morning";
            else if (TimeNow >= new TimeSpan(12, 0, 0) && TimeNow < new TimeSpan(16, 0, 0))
                return "Afternoon";
            else if (TimeNow >= new TimeSpan(16, 0, 0) && TimeNow < new TimeSpan(20, 0, 0))
                return "Evening";
            return "Night";
        }
    }
}