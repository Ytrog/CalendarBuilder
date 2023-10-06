using CalendarBuilder.Controls;
using CalendarBuilder.Model;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Globalization;

namespace CalendarBuilder
{
    public partial class Main : Form
    {

        private MonthControl? monthControl = null;

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

            SelectCurrentMonth();
        }

        private void SelectCurrentMonth()
        {
            int currentMonth = DateTime.Now.Month;

            int monthIndex = currentMonth - 1; // The list begins with 0, months begin with 1

            tsMonth.SelectedIndex = monthIndex;
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
            monthControl = new MonthControl(MonthCalendar);
            toolStripContainer1.ContentPanel.Controls.Clear();
            toolStripContainer1.ContentPanel.Controls.Add(monthControl);
            monthControl.Dock = DockStyle.Fill;
            monthControl.Show();

            btnPrint.Enabled = true;

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (monthControl == null)
            {
                return;
            }

            printDocument.DocumentName = $"{tsMonth.Text} {tsYears.Text}";
            printDocument.DefaultPageSettings.Landscape = true;

            PrinterSettings? defaultPrinter = GetDefaultPrinterSettings();

            if (defaultPrinter == null)
            {
                throw new InvalidPrinterException(new PrinterSettings());
            }

            printDocument.DefaultPageSettings.PaperSize = defaultPrinter.DefaultPageSettings.PaperSize;

            printPreviewDialog.Document = printDocument;

            printPreviewDialog.ShowDialog(this);
        }

        private static PrinterSettings? GetDefaultPrinterSettings()
        {
            PrinterSettings printerSettings = new PrinterSettings();

            if (printerSettings.IsDefaultPrinter)
            {
                return printerSettings;
            }

            return null;
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (monthControl == null || e.Graphics == null)
            {
                return;
            }

            try
            {
                monthControl.DisableScrollBars();

                Bitmap bitmap = new(monthControl.Bounds.Width, monthControl.Bounds.Height);
                monthControl.DrawToBitmap(bitmap, monthControl.Bounds);

                e.Graphics.DrawImage(bitmap, e.MarginBounds, 0, 0, bitmap.Width, bitmap.Height, GraphicsUnit.Pixel);
            }
            finally
            {
                monthControl.EnableScrollBars();
            }
        }
    }
}