using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Abstract_Const
{
    class VAT : Company
    {
        public void AddNewDirectorToVAT()
        {
            Console.WriteLine("VAT director added");
        }

        public void SetDevidents()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("VAT devidents");
            Console.ResetColor();
        }
    }
}
