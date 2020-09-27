using System;

namespace GC_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GetTotalMemory: " + GC.GetTotalMemory(false));
            Person[] person = new Person[100];
            Console.WriteLine("CollectionCount 0: " + GC.CollectionCount(0));
            Console.WriteLine("CollectionCount 1: " + GC.CollectionCount(1));
            Console.WriteLine("CollectionCount 2: " + GC.CollectionCount(2));

            for (int i = 0; i < 100; i++)
            {
               // Person p = new Person();
                person[i] = new Person();
               // Console.WriteLine("GetTotalMemory: " + GC.GetTotalMemory(false));
               // GC.Collect();
               // Console.WriteLine("GetGeneration: " + GC.GetGeneration(p));              
            }


            Console.WriteLine("CollectionCount 0: " + GC.CollectionCount(0));
            Console.WriteLine("CollectionCount 1: " + GC.CollectionCount(1));
            Console.WriteLine("CollectionCount 2: " + GC.CollectionCount(2));
            //for (int i = 0; i < 100000; i++)
            //{
            //    person[i].Foo(i);
            //}          
            Console.ReadKey();
        }
    }

    class Person
    {
        public int [] i = new int[100000];
        public void Foo(int x)
        {
           
        }

        ~ Person()//  фіналізатор
        {
            Console.WriteLine("I will die... clear resources");
        }
    }

}
