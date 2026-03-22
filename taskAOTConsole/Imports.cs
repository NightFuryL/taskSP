using System.Runtime.InteropServices;
namespace taskAOTConsole
{
    public static class Imports
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);
    }
}
