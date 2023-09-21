using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBuilder.Model
{
    public class Day
    {
        public DayOfWeek DayOfWeek { get; init; }
        public int DayOfMonth { get; init; }

        public Day(DayOfWeek dayOfWeek, int dayOfMonth)
        {
            DayOfWeek = dayOfWeek;

            if (dayOfMonth > 0 && dayOfMonth <= 31) 
            {
                this.DayOfMonth = dayOfMonth;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(dayOfMonth));
            }
        }
    }
}
