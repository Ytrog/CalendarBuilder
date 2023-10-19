using CalendarBuilder.Model;
using System.Globalization;

namespace CalendarBuilder
{
    public static class CalendarManager
    {
        private static readonly GregorianCalendar calendar = new(GregorianCalendarTypes.Localized);

        public static Month CreateCalendar(int year, int month)
        {
            // get the weeknumbers using ISOWeek
            int daysinMonth = calendar.GetDaysInMonth(year, month);
            Dictionary<int, List<Model.Day>> days = new();

            for (int i = 1; i < daysinMonth + 1; i++) // days are from 1 to daysInMonth + 1; not 0 to daysInMonth
            {
                DateTime date = new DateTime(year, month, i);
                var day = new Model.Day(calendar.GetDayOfWeek(date), calendar.GetDayOfMonth(date));
                int weeknumber = ISOWeek.GetWeekOfYear(date);

                if (!days.ContainsKey(weeknumber) || days[weeknumber] == null)
                {
                    days[weeknumber] = new();
                }
                days[weeknumber].Add(day);

            }

            // create a month (perhaps a month has weeks and weeks have days?)
            Month currentMonth = new(year, month);

            foreach (int weeknumber in days.Keys)
            {
                Week week = new(weeknumber, days[weeknumber].ToArray());
                currentMonth.Weeks.Add(week);
            }

            return currentMonth;

        }
    }
}
