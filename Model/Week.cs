﻿namespace CalendarBuilder.Model
{
    public class Week
    {
        public Day[] Days { get; init; }
        public int WeekNumber { get; init; }

        /// <summary>
        /// Initialize a <see cref="Week"/>. As often a month doesn't begin on Monday a week on the calendar doesn't need to have 7 days
        /// </summary>
        /// <param name="days"></param>
        public Week(int weeknumber , Day[] days)
        {
            if (weeknumber < 1 || weeknumber > 52)
            {
                throw new ArgumentOutOfRangeException(nameof(weeknumber));
            }

            if (!days.Any() || days.Length > 7)
            {
                throw new ArgumentException("Must provide between 1 and 7 days", nameof(days));
            }

            WeekNumber = weeknumber;
            Days = days;
        }
    }
}
