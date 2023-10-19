using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBuilder.Model
{
    public class Month
    {
        public List<Week> Weeks { get; init; }

        public int MonthNumber { get; init; }

        public int Year { get; init; } 

        public Month(int year, int monthNumber)
        {
            Weeks = new List<Week>();
            MonthNumber = monthNumber;
            Year = year;
        }

        public override string ToString()
        {
            return new DateTime(Year, MonthNumber, 1).ToString("Y");
        }
    }
}
