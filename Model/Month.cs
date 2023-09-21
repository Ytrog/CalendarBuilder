using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBuilder.Model
{
    public class Month
    {
        public List<Week> Weeks { get; init; }

        public Month()
        {
            Weeks = new List<Week>();
        }
    }
}
