using System.Runtime.InteropServices;
namespace taskConsole
{
    public static class Imports
    {
        public delegate bool EnumWC(IntPtr hWnd, IntPtr lParam);
        [DllImport("kernel32.dll")]
        public static extern bool Beep(uint dwFreq, uint dwDuration);
        [DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "printf")]
        public static extern int FormattedPrintC(string format, __arglist);
        [DllImport("user32.dll", CharSet = CharSet.Unicode, ExactSpelling = false)]
        public static extern int MessageBox(IntPtr hWnd, string lpText, string lpCaption, uint uType);
        [DllImport("user32.dll")]
        public static extern int EnumWindows(EnumWC lpEnumFunc, IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = false, SetLastError = true)]
        public static extern int GetWindowText(IntPtr hWnd, System.Text.StringBuilder lpString, int nMaxCount);
    }
}
