using System;
using System.Collections;

namespace Lessn_6_Collection
{
    class Program
    {
        //  no generic collections
        //ArrayList
        //BitArray
        //HashtaЬle
        //Queue
        //SortedList
        //Stack

        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList(new int[] { 3, 5, 7 });// ICollection
            ArrayList arr2 = new ArrayList(5);//capacity
            //arr2.AddRange(arr);
            //arr2.AddRange(new int[] { 2, 8});
           // arr2.Add("hello");

            //foreach (var item in arr2)
            //{
            //    System.Console.WriteLine(item);
            //}
            //System.Console.WriteLine(arr2.Capacity);
            //arr2.TrimToSize();
            //Console.WriteLine(arr2.Capacity);

            Console.WriteLine(arr2.Contains("hello"));
            Console.WriteLine(arr2.IndexOf("hello"));

           // arr2.Remove("hello");
            Console.WriteLine("-------------------------------");

            foreach (var item in arr2)
            {
                System.Console.WriteLine(item);
            }

            Car car1 = new Car("BMW");
            Car car2 = new Car("Mersedes");
            arr2.Add(car1);
            arr2.Add(car2);
            Console.WriteLine("-------------------------------");
            foreach (var item in arr2)
            {
                System.Console.WriteLine(item);
            }

            //arr2.Remove(car1);
            Console.WriteLine("-------------------------------");
            arr2.Sort();
            foreach (var item in arr2)
            {
                System.Console.WriteLine(item);
            }
            var element = (Car)arr2[1];            
        }
    }

    class Car : IComparable
    {
        public Car(string n)
        {
            name = n;
        }
        public string name;

        public override string ToString()
        {
            return name;
        }

        public int CompareTo(object obj)
        {
            return this.name.CompareTo(((Car)obj).name);
        }
    }
}
