using System.Globalization;

namespace taskConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Imports.Beep(1000, 500);
            Imports.FormattedPrintC("Beeped at %d Hz for %d ms\n", __arglist(1000, 500));
            Imports.MessageBox(IntPtr.Zero, "Hello, World!", "Message", 0);
            Imports.MessageBox(IntPtr.Zero, "This is a message box. 😁😁👍👍😂😒", "Message Box", 0);
            Imports.EnumWindows(OutputWindow, IntPtr.Zero);
        }
        public static bool OutputWindow(IntPtr hWnd, IntPtr lParam)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(256);
            if (Imports.GetWindowText(hWnd, sb, sb.Capacity) > 0)
            {
                string windwowName = sb.ToString();
                Console.WriteLine($"Window Handle: {hWnd.ToInt64().ToString()}, Title: {windwowName}");
            }
            return true;
        }
    }
}
