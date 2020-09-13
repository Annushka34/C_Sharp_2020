using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Abstract_Const
{
    sealed class PAT : Company
    {
        public void AddEmployee()
        {
            Console.WriteLine("add employee");
        }

        public new void SetDevidents()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("PAT devidents");
            Console.ResetColor();
        }
    }


    class MyClass : List<int>
    {

    }
}
