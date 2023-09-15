using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBuilder
{
    internal class CalendarManager
    {
        public CalendarManager()
        {
            
        }

        public Calendar CreateCalendar(int year, int month)
        {
            // get the weeknumbers using ISOWeek
            // create a month (perhaps a month has weeks and weeks have days?)
        }
    }
}
