using System;
using System.IO;

namespace Dispose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person p = new Person();
            p.Dispose();
            p.Dispose();

            using (Person p1 = new Person())
            {
                //   work with person
            }

            

            using (FileStream fs = new FileStream("dvsd.txt", FileMode.OpenOrCreate))
            {

            }
        }
    }


    class Person : IDisposable
    {
        FileStream fileStream;
        public Person()
        {
            fileStream = new FileStream("D://new.txt", FileMode.OpenOrCreate);
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose");
            fileStream.Close();
            fileStream.Dispose();
        }
    }
}
