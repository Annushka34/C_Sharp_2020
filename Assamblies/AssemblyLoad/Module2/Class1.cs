using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    public class Class1 : MyIntarface
    {
        public string Hello()
        {
            Console.WriteLine("hello from module 2");
            return "module2";
        }
    }
}
