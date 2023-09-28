﻿using CalendarBuilder.Model;

namespace CalendarBuilder.Controls
{
    public partial class DayControl : UserControl
    {
        public Model.Day? Day { get; init; }

        public DayControl()
        {
            InitializeComponent();
            LoadData();

        }

        public DayControl(Model.Day day) : this()
        {
            Day = day;
        }

        private void LoadData()
        {
            if (Day != null)
            {
                lblDay.Text = $"{Day.DayOfWeek} {Day.DayOfMonth}";
            }
            else
            {
                lblDay.Text = nameof(lblDay);
            }
        }
    }
}
