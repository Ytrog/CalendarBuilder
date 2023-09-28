using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalendarBuilder.Model;

namespace CalendarBuilder.Controls
{
    public partial class WeekControl : UserControl
    {
        public Model.Week? Week { get; init; }

        public WeekControl(Week? week)
        {
            Week = week;
        }

        public WeekControl()
        {
            InitializeComponent();
        }

        private void WeekControl_Load(object sender, EventArgs e)
        {
            if (Week != null)
            {
                lblWeekNumber.Text = Week.WeekNumber.ToString();

                DayControl[] days = new DayControl[7];
                

                foreach (Model.Day day in Week.Days)
                {
                    switch (day.DayOfWeek)
                    {
                        case DayOfWeek.Sunday:
                            days[7] = new DayControl(day);
                            break;
                        case DayOfWeek.Monday:
                            days[0] = new DayControl(day);
                            break;
                        case DayOfWeek.Tuesday:
                            days[1] = new DayControl(day);
                            break;
                        case DayOfWeek.Wednesday:
                            days[2] = new DayControl(day);
                            break;
                        case DayOfWeek.Thursday:
                            days[3] = new DayControl(day);
                            break;
                        case DayOfWeek.Friday:
                            days[4] = new DayControl(day);
                            break;
                        case DayOfWeek.Saturday:
                            days[5] = new DayControl(day);
                            break;
                        default:
                            break;
                    }
                }

                for (int i = 0; i < days.Length; i++)
                {
                    if (days[i] == null)
                    {
                        days[i] = new DayControl();
                    }
                }
            }
        }
    }
}
