using System;
using System.Text;
using Calculator;

namespace Lesson_4_Perevantazennja
{
    class Program
    {
        static void Main(string[] args)
        {
            Multiply calculator = new Multiply();
            calculator.Mult(10, 3);

            //Point p1 = new Point(1, 7, "point 1");
            //Point p2 = new Point(3, 7, "point 2");

            //Console.WriteLine(p1.ToString());
            ////Console.WriteLine(p2);

            ////Point p3 = p1 + p2;//   ovverride Point + Point
            ////Console.WriteLine(p3);

            ////int a = 10 + p1;//   ovverride int + Point
            ////Point p4 = p1 + 10;//   ovverride Point + int

            ////Console.WriteLine(a);

            //p1++;
            //Console.WriteLine(p1);

            //++p1;
            //Console.WriteLine(p1);

            //Console.WriteLine(p1 == p2);
            ////Console.WriteLine(p1.Equals(p2));   

            //p1.x = 100;
            //p1 = p1 >> 2;
            //Console.WriteLine(p1);

            //Console.WriteLine("[]");

            //MyCollection myCollection = new MyCollection(10);
            //Console.WriteLine(myCollection);
            //Console.WriteLine(myCollection[3]);
            //myCollection[0] = 100;
            //Console.WriteLine(myCollection);
            //Console.WriteLine(myCollection["Ivanov"]);
            //Console.WriteLine(myCollection[1,5]);


            ////------------Приведення від Point до Point3D

            //Point3D pd = p1;
            //Console.WriteLine(pd);
            //int a = (int)p1;
            //Console.WriteLine("a = " + a);
            //Point pd1 = 5;
            //Console.WriteLine(pd1);

            OverrideFromObject();
        }


        static void OverrideFromObject()
        {
            string str1 = "hello";
            string str2 = "hello";

            Console.WriteLine(str1);
            Console.WriteLine(str2);

            Console.WriteLine(str1 == str2);
            Console.WriteLine(str1.Equals(str2));
            Console.WriteLine(str1.GetHashCode());
            Console.WriteLine(str2.GetHashCode());//хеш коди будуть рівні бо слова однакові
            // і працює оптимізатор коду

            Console.WriteLine("add 1");
            str1 += "1";
            Console.WriteLine(str1.GetHashCode());//   hash code  - unique code for every object
            Console.WriteLine(str2.GetHashCode());

            Console.WriteLine("compare objects");
            MyType obj1 = new MyType(1);
           // obj1.name += "a";
            MyType obj2 = new MyType(2);
            Console.WriteLine(obj1.Equals(obj2));
            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());


            //---------------------------------
            Console.WriteLine("String builder vs string");
            string str3 = "hello";
            Console.WriteLine(str3.GetHashCode());
            str3 += "1";
            Console.WriteLine(str3.GetHashCode());
            str3 = str3.Remove(2, 1);
            Console.WriteLine(str3.GetHashCode());

            Console.WriteLine();
            StringBuilder strB = new StringBuilder("hello");
            Console.WriteLine(strB.GetHashCode());
            strB.Append("1");
            Console.WriteLine(strB.GetHashCode());
            strB.Remove(2, 1);
            Console.WriteLine(strB.GetHashCode());
            Console.WriteLine(strB);
        }

        class MyType
        {
           public string name;
            public MyType(int a)
            {
                name = "hello";
            }

            public override bool Equals(object obj)
            {
                return ((MyType)obj).name == this.name;
            }
            public override int GetHashCode()
            {
                return name.GetHashCode();
            }
        }
    }
}
