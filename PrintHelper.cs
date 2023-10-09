using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBuilder
{
    internal static class PrintHelper
    {
        public static void DrawControl(Control control,Bitmap bitmap) // TODO doesn't draw first week correcly + backgroudn weird
        {
            if (!ValidateBounds(control.Bounds))
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

        private static void LogControlBounds(Control control)
        {
            string name = control.Name;

            File.AppendAllText(@"c:\test\controls.log", $"{name}: x:{control.Bounds.X} y: {control.Bounds.Y} w: {control.Bounds.Width} h: {control.Bounds.Height}{Environment.NewLine}");
        }

    }
}
