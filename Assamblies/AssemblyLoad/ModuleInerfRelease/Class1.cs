using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleInerfRelease
{
    public class ClassMyRelease : MyIntarface
    {
        public string Hello()
        {
            Console.WriteLine("hello from module 3");
            return "complite interface";
        }
    }
}
