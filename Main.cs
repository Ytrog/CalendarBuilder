using CalendarBuilder.Controls;
using CalendarBuilder.Model;
using System.Diagnostics;
using System.Globalization;

namespace CalendarBuilder
{
    public partial class Main : Form
    {

        public Main()
        {
            CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("nl-nl");
            CultureInfo.CurrentUICulture = CultureInfo.CurrentCulture;
            InitializeComponent();
            tsYears.Text = DateTime.Now.Year.ToString();
            FillMonths();
        }


        private void FillMonths()
        {
            tsMonth.Items.Clear();
            tsMonth.Items.AddRange(DateTimeFormatInfo.CurrentInfo.MonthNames);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // get the year
            int year;
            if (!int.TryParse(tsYears.Text, out year))
            {
                MessageBox.Show(this, "Het jaar moet een getal zijn", "Invoerfout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // get the month (number)
            int month = tsMonth.SelectedIndex + 1; // 1 <= month <= 12

            // create the month
            Month MonthCalendar = CalendarManager.CreateCalendar(year, month);

            // show the calendar
            MonthControl monthControl = new MonthControl(MonthCalendar);
            toolStripContainer1.ContentPanel.Controls.Clear();
            toolStripContainer1.ContentPanel.Controls.Add(monthControl);
            monthControl.Dock = DockStyle.Fill;
            monthControl.Show();

        }
    }
}