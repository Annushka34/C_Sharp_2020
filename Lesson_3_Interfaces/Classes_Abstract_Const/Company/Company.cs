using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Abstract_Const
{
    class Company
    {
        private int emploeesAmount;
        public string CompanyName { get; set; }
        protected string Licence { get; set; }
        public Company()
        {
            Random r = new Random();
            emploeesAmount = r.Next(10, 100);
        }
        public void ShowCompanyInfo()
        {
            Print(CompanyName);
            Print(Licence);
            Print(emploeesAmount.ToString());
        }

        protected void SetLicence(string lic)
        {
            Licence = lic;
            Print(CompanyName);
        }

        private void Print(string str)
        {
            Console.WriteLine($"*****    {str}    *****");
        }

        public virtual void SetDevidents()
        {
            Console.WriteLine("base set devident");
        }
    }
}
