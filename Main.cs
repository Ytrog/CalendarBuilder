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
    }
}