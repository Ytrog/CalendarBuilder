using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBuilder.Model
{
    public class Month
    {
        public required List<Week> Weeks { get; set; }

        public Month()
        {
            Weeks = new List<Week>();
        }
    }
}
