using CalendarBuilder.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarBuilder.Controls
{
    public partial class MonthControl : UserControl
    {
        public Model.Month? Month { get; init; }

        public MonthControl(Month? month)
        {
            Month = month;
        }

        public MonthControl()
        {
            InitializeComponent();
        }

        private void MonthControl_Load(object sender, EventArgs e)
        {
            if (Month != null)
            {
                foreach (Week week in Month.Weeks.OrderBy(w => w.WeekNumber)) 
                {
                    flowLayoutPanel1.Controls.Add(new WeekControl(week));
                }
            }
        }
    }
}
