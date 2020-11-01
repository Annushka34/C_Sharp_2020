using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dll.Class1 c = new Dll.Class1();
            c.HelloDll();
            Console.ReadLine();
        }
    }
}
