using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ImportC_dll;

namespace ImportC_dll
{
    class Program
    {
        [DllImport("C_dll.dll")]
        public static extern void hello();
        [DllImport("C_dll.dll")]
        public static extern void helloStatic();
        [DllImport("C_dll.dll")]
        public static extern int countSum(int a, int b);
        [DllImport("CPlusDll2.dll")]
        public static extern int MyCoolMethod();
        static void Main(string[] args)
        {
            hello();
            helloStatic();
            Console.WriteLine(countSum(10, 20));
            Console.WriteLine(MyCoolMethod());
        }
    }
}
