using System;
using System.Collections;

namespace Hashtable_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hash = new Hashtable();
           // SortedList hash = new SortedList();
           //  едементи вставляються в відсотрованому порядку і мають бути одного типу


            hash.Add(10, "Ivanov");
            hash.Add(15, "Petrov");
          //  hash.Add(10, "Ivanov"); - exception
            hash[10] = "Sidorov";//  replace value
            hash.Add('a', "Pupkin");

            foreach (var key in hash.Keys)
            {
                Console.WriteLine(key + ":" + hash[key]);
            }
            Console.WriteLine("-----------------------------------");
            foreach (var val in hash.Values)
            {
                Console.WriteLine(val);
            }

            hash.Remove(15);
            

            Console.WriteLine("-----------------------------------");
            foreach (var val in hash.Values)
            {
                Console.WriteLine(val);
            }
            //hash.Add(new MyKey(), 23);
            //hash.Add(new MyKey(), 23);
            //hash.Add(new MyKey(), 23);

           
        }
    }

    class MyKey
    {
        string name;
    }
}
