namespace CalendarBuilder.Model
{
    public class Week : IComparable<Week>
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

        public int CompareTo(Week? other)
        {
            // any value is bigger than null
            if (other == null)
            {
                return 1;
            }


            // implement the special wrap-around where 1 > 52 as january can start with week 52 and december can end with week 1
            if (this.WeekNumber == 1 && other.WeekNumber == 52)
            {
                return 1;
            }
            else if (this.WeekNumber == 52 && other.WeekNumber == 1)
            {
                return -1;
            }
            else 
            {
                return this.WeekNumber.CompareTo(other.WeekNumber);
            }
        }
    }
}
