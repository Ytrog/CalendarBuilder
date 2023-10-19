using CalendarBuilder.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            if (control is UserControl userControl)
            {
                userControl.BorderStyle = BorderStyle.FixedSingle;
                userControl.Update();
            }

            LogControlBounds(control);

            control.DrawToBitmap(bitmap, control.Bounds);

            //Graphics graphics = Graphics.FromImage(bitmap);

            //if (graphics != null)
            //{
            //    graphics.DrawRectangle(Pens.Black, control.Bounds);
            //}

            foreach (Control childControl in control.Controls)
            {
                DrawControl(childControl, bitmap);
            }
        }

        public static void DrawBorders(Control control, Bitmap bitmap)
        {
            Rectangle bounds = control.Bounds;
            var offset = control.PointToScreen(bounds.Location);

            bounds.Offset(offset);

            if (!ShouldPrint(control) && control is not DayControl && control is not WeekControl)
            {
                return;
            }

            Color color = Color.Black;
            const uint thickness = 2;

            Graphics graphics = Graphics.FromImage(bitmap);

            graphics.DrawRectangle(Pens.Black, bounds);

            //for (int i = 0; i < bounds.Width; i++)
            //{
            //    for (int j = 0; j < bounds.Height; j++)
            //    {

            //        // check bounds
            //        if (bounds.X + i >= bitmap.Width || bounds.Y + j >= bitmap.Height)
            //        {
            //            continue;
            //        }

            //        // vertical borders
            //        if (i <= thickness || i >= bounds.Width - thickness)
            //        {
            //            bitmap.SetPixel(bounds.X + i, bounds.Y + j, color);
            //        }

            //        // horizontal borders
            //        if (j <= thickness || j >= bounds.Height - thickness)
            //        {
            //            bitmap.SetPixel(bounds.X + i, bounds.Y + j, color);
            //        }

            //    }
            //}

            foreach (Control childControl in control.Controls)
            {
                DrawBorders(childControl, bitmap);
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
