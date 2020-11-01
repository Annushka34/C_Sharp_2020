using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson16_Assambly
{
    class Program
    {
        private const UInt32 WM_QUIT = 0x0012;
        static void Main(string[] args)
        {
            //MyDll.MessageBoxA(IntPtr.Zero,"hello", "My MB", 0);

            //string processName = "notepad.exe";
            //string text;
            //Console.Write("Enter text: ");
            //text = Console.ReadLine();
            //Process p = Process.Start(processName);
            //p.WaitForInputIdle();
            //IntPtr h = p.MainWindowHandle;
            //MyDll.SetForegroundWindow(h);
            //SendKeys.SendWait(text);



            MyDll.puts("hello");

            unsafe
            {
                int b = 10;
                int* a = &b;
                Console.WriteLine(*a);
            }

                Assembly asm = Assembly.LoadFrom(@"D:\STEP\c#\c#1\Assamblies\Lesson16_Assambly\NewAssambly\bin\Debug\NewAssambly.exe");
                Type t = asm.GetType("NewAssambly.Program", true, true);

                // создаем экземпляр класса Program
                object obj = Activator.CreateInstance(t);

                if (obj == null) Console.WriteLine("not created");

                Console.WriteLine("Вызов метода Main");
                MethodInfo method = t.GetMethod("Main", BindingFlags.DeclaredOnly
                        | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Static);

                method.Invoke(obj, new object[] { new string[] { } });

        }
    }
}

//ildasm
//dumpbin /headers
//D:\ШАГ\с#\examples\Lesson16_Assambly\Lesson16_Assambly
