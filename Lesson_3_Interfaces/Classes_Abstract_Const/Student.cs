using System;

namespace Classes_Abstract_Inheritance
{
    class Student : ICoffeable
    {
        public void DrinkCofee()
        {
            Console.WriteLine("more water less coffee");
        }

        public void GoOnWorkPlace()
        {
            throw new Exception("I m died");
        }
    }
}
