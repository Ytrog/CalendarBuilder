using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBuilder.Model
{
    internal class Week
    {
        public required Day[] Days { get; init; } = new Day[7];
    }
}
