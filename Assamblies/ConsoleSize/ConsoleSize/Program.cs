using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSize
{


    //class Program
    //{
    //    private const int MF_BYCOMMAND = 0x00000000;
    //    public const int SC_CLOSE = 0xF060;
    //    public const int SC_MINIMIZE = 0xF020;
    //    public const int SC_MAXIMIZE = 0xF030;
    //    public const int SC_SIZE = 0xF000;

    //    [DllImport("user32.dll")]
    //    public static extern int DeleteMenu(IntPtr hMenu, int nPosition, int wFlags);

    //    [DllImport("user32.dll")]
    //    private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

    //    [DllImport("kernel32.dll", ExactSpelling = true)]
    //    private static extern IntPtr GetConsoleWindow();

    //    static void Main(string[] args)
    //    {
    //        Console.WindowHeight = 20;
    //        Console.WindowWidth = 30;

    //        IntPtr handle = GetConsoleWindow();
    //        IntPtr sysMenu = GetSystemMenu(handle, false);

    //        if (handle != IntPtr.Zero)
    //        {
    //            DeleteMenu(sysMenu, SC_CLOSE, MF_BYCOMMAND);
    //            DeleteMenu(sysMenu, SC_MINIMIZE, MF_BYCOMMAND);
    //            DeleteMenu(sysMenu, SC_MAXIMIZE, MF_BYCOMMAND);
    //            DeleteMenu(sysMenu, SC_SIZE, MF_BYCOMMAND);
    //        }
    //        Console.Read();
    //        Console.WriteLine("Hello");
    //    }

    //}



    //}


    class Program
    {
        static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);
        static readonly IntPtr HWND_TOP = new IntPtr(0);
        const UInt32 SWP_NOSIZE = 0x0001;
        const UInt32 SWP_NOMOVE = 0x0002;
        const UInt32 SWP_NOZORDER = 0x0004;
        const UInt32 SWP_NOREDRAW = 0x0008;
        const UInt32 SWP_NOACTIVATE = 0x0010;
        const UInt32 SWP_FRAMECHANGED = 0x0020;
        const UInt32 SWP_SHOWWINDOW = 0x0040;
        const UInt32 SWP_HIDEWINDOW = 0x0080;
        const UInt32 SWP_NOCOPYBITS = 0x0100;
        const UInt32 SWP_NOOWNERZORDER = 0x0200;
        const UInt32 SWP_NOSENDCHANGING = 0x0400;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();
        private const int SW_MINIMIZE = 6;
        private const int SW_MAXIMIZE = 4;

        static void Main(string[] args)
        {
            IntPtr ConsoleHandle = GetConsoleWindow();
            SetWindowPos(ConsoleHandle, HWND_NOTOPMOST, 0, 0, 300, 300, SWP_NOMOVE);
            ShowWindow(ConsoleHandle, SW_MAXIMIZE);

            Console.WriteLine("end");
            Console.ReadLine();
        }
    }
}

