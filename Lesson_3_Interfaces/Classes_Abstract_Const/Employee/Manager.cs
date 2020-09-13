using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Abstract_Const
{
    class Manager : Employee
    {
        public Manager(): base ("no name")
        {

        }
        public override int CalcSalary(int proffit)
        {
            int salary = (int)(Salary.ManagerSalary * ((double)proffit / 100 + 1));
            return salary;
        }
    }
}
