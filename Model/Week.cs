namespace CalendarBuilder.Model
{
    public class Week
    {
        public required Day[] Days { get; init; }

        /// <summary>
        /// Initialize a <see cref="Week"/>. As often a month doesn't begin on Monday a week on the calendar doesn't need to have 7 days
        /// </summary>
        /// <param name="days"></param>
        public Week(params Day[] days)
        {
            Days = days;
        }
    }
}
