using CalendarBuilder.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBuilder
{
    internal static class PrintHelper
    {
        public static void DrawControl(Control control, Bitmap bitmap)
        {
            if (!ShouldPrint(control))
            {
                return;
            }

            //LogControlBounds(control);

            control.DrawToBitmap(bitmap, control.Bounds);

            foreach (Control childControl in control.Controls)
            {
                DrawControl(childControl, bitmap);
            }
        }

        public static void DrawBorders(Control control, Bitmap bitmap)
        {


            Rectangle bounds = control.Bounds;

            if (!ShouldPrint(control) && control is not DayControl && control is not WeekControl)
            {
                return;
            }


            // Only print the days, the others are the parents
            if (control is DayControl)
            {
                // get the WeekControl ancestor and set the Y to the Y of the WeekControl
                if (control.Parent?.Parent is WeekControl week)
                {
                    Debug.WriteLine($"parent.parent: {week.Bounds}");

                    bounds.Y = week.Bounds.Y;
                }

                Graphics graphics = Graphics.FromImage(bitmap);

                graphics.DrawRectangle(Pens.Black, bounds);
            }

            foreach (Control childControl in control.Controls)
            {
                DrawBorders(childControl, bitmap);
            }

        }

        /// <summary>
        /// Draw the month and year at the top
        /// </summary>
        /// <param name="printableMonthControl"></param>
        /// <param name="bitmap"></param>
        internal static void DrawHeader(MonthControl printableMonthControl, PrintPageEventArgs e)
        {
            if (e.Graphics is null)
            {
                return;
            }

            if (printableMonthControl.Month is Model.Month month)
            {
                Font font = SystemFonts.DefaultFont;
                Brush brush = new SolidBrush(Color.Black);
                PointF origin = e.MarginBounds.Location; // implicit Point -> PointF
                Size offset = new Size(0, 50);

                e.Graphics.DrawString(month.ToString(), font, brush, origin - offset);
            }

        }

        private static bool ValidateBounds(Rectangle rect)
        {
            if (rect.IsEmpty || rect.Width == 0 || rect.Height == 0)
            {
                return false;
            }

            return true;
        }

        private static bool ShouldPrint(Control control)
        {
            if (control == null || control.GetType() == typeof(WeekControl) || control.GetType() == typeof(DayControl) || control.GetType() == typeof(Label))
            {
                return false;
            }

            return ValidateBounds(control.Bounds);

        }

        private static void LogControlBounds(Control control)
        {
            string name = control.Name;

            File.AppendAllText(@"c:\test\controls.log", $"{name}:\t x:{control.Bounds.X} y: {control.Bounds.Y} w: {control.Bounds.Width} h: {control.Bounds.Height} x+w: {control.Bounds.X + control.Bounds.Width} y+h: {control.Bounds.Y + control.Bounds.Height} {Environment.NewLine}");
        }

        
    }
}
