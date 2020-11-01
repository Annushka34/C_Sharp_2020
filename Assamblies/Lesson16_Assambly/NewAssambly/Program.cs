using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NewAssambly
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 indent = 0;
            Console.WriteLine("New assambly was load");
            Assembly a = typeof(_Module).Assembly;
            Console.WriteLine( a.GetName());
            Console.WriteLine("Codebase={0}", a.CodeBase);

        }
    }
}
