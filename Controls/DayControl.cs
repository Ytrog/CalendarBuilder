using CalendarBuilder.Model;
using System.Diagnostics;
using System.Globalization;

namespace CalendarBuilder.Controls
{
    public partial class DayControl : UserControl
    {
        public Model.Day? Day { get; init; }

        public DayControl()
        {
            InitializeComponent();
            lblDay.Visible = false;
        }

        public DayControl(Model.Day day) : this()
        {
            Day = day;
            LoadData();
        }

        private void LoadData()
        {
            if (Day != null)
            {
                lblDay.Text = $"{DateTimeFormatInfo.CurrentInfo.GetDayName(Day.DayOfWeek)} {Day.DayOfMonth}";
                lblDay.Visible = true;
            }
            else
            {
                lblDay.Text = String.Empty;
            }
        }
    }
}
