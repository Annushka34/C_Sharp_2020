using Classes_Abstract_Inheritance;
using System;

namespace Classes_Abstract_Const
{
    abstract class Employee : ICoffeable, IWorkOvertimeable
    {
        private string _name;
        public int WorkTime { get; set; }
        public Employee(string name)
        {
            _name = name;
        }
        void Show()
        {
            Console.WriteLine($"{_name}   {WorkTime}");
        }

        public abstract int CalcSalary(int proc);

        public void DrinkCofee()
        {
            Console.WriteLine("njam-njam-njam");
        }

        public void GoOnWorkPlace()
        {
            Console.WriteLine("((((:-");
        }

        public void Work2HourMore()
        {
            WorkTime += 2;
            Show();
        }

        public void Work4HourMore()
        {
            WorkTime += 4;
            Show();
        }

        public void GoHome()
        {
            WorkTime = 0;
            Show();
        }
    }
}
