using System;
using Part1;
using Part2;

namespace Lesson_2_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyEnum myEnum = new MyEnum();
            myEnum.Set();


            NullCond nc = new NullCond();
            Person p = null;
            nc.TakePerson(p);

            Student s = new Student("Ivanov");
            s.SetAge(20);

            Student s1 = new Student("Petrov");
            s1.SetAge(20);

            Console.WriteLine(Student.UNIVERSITY);
            Console.WriteLine(Student.counter);


            Console.WriteLine("\nPROPERTIES: ");
            Calculation calc = new Calculation();
            calc.SetX(10);
            Console.WriteLine(calc.GetX());

            calc.SetY = 12;
           // Console.WriteLine(calc.SetY);
            Console.WriteLine(calc.GetY);


            calc.Y = 12;
            int a = calc.Y;

            calc.Name = "Point 1";
            // calc.Operation = '-'; set private
            Console.WriteLine(calc.Operation);
            // Console.WriteLine(calc.Name);


            Console.WriteLine(Settings.Factorial(5));
            if (Settings.Key != null)
            {

            }
        }
    }
}
