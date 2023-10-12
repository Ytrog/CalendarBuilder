using CalendarBuilder.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBuilder
{
    internal static class PrintHelper
    {
        public static void DrawControl(Control control,Bitmap bitmap) 
        {
            if (!ShouldPrint(control))
            {
                return;
            }

            LogControlBounds(control);

            control.DrawToBitmap(bitmap, control.Bounds);
            foreach (Control childControl in control.Controls)
            {
                DrawControl(childControl, bitmap);
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
