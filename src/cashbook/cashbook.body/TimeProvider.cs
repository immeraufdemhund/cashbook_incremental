using System;

namespace cashbook.body
{

    public static class TimeProvider
    {
        public static Func<DateTime> Now { get; set; }
    }
}