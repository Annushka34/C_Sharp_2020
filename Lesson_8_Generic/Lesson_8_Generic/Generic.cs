using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_Generic
{
    static class Generic
    {
        public static void ShowGeneric()
        {
            //MyClass<int> myClass = new MyClass<int>();
            //MyClass<char> myClass2 = new MyClass<char>();
            ////MySimpleClass simpleClass = new MySimpleClass();
            ////simpleClass.Add(10);


            //var mm = new MyClass<int>();

            //MyDerivedClass myDerived = new MyDerivedClass();
            //myDerived.Add(11);

            //MyDerivedClassT<char> derivedClassT = new MyDerivedClassT<char>();
            //derivedClassT.Add('2');


            //MySimpleClass classWithTMeth = new MySimpleClass();
            //classWithTMeth.PrintSymb<double>(123);
            //classWithTMeth.PrintTwoSymb<char, string>('a', "hello");

            //MyClass<int> myClass1 = new MyClass<int>();
            //myClass1.Add(3);

            MyClass<int[]> myClass = new MyClass<int[]>();

            string str = "Hello";
            str.Show();

            int[] arr1 = new int[] { 1, 5, 7, 10 };
            arr1.Show<int>();

            List<string> list = new List<string> { "fff", "www", "qqq", "lll" };
            list.Show<string>();
        }
    }


    class MyClass<T> where T: IEnumerable
    {
        protected T[] arr = new T[10];
        protected int count = 0;
        public void Add(T val)
        {
            arr[count] = val;
            count++;
        }

        public T Get(int ind)
        {
            return arr[ind];
        }
    }

    //class MyDerivedClass : MyClass<int>
    //{
    //    public void Minus(int val)
    //    {
    //        count--;
    //    }
    //}

    //class MyDerivedClassT<T> : MyClass<T> where T: struct
    //{
    //    public void Minus(T val)
    //    {
    //        count--;
    //    }
    //}


    //class MySimpleClass
    //{
    //    void Show()
    //    {

    //    }

    //    public void PrintSymb <T> (T symb)
    //    {
    //        Console.WriteLine(symb);
    //        Console.WriteLine(symb.GetType());
    //    }

    //    public void PrintTwoSymb<T, U>(T symb1, U symb2)
    //    {
    //        Console.WriteLine(symb1);
    //        Console.WriteLine(symb1.GetType());
    //        Console.WriteLine(symb2);
    //        Console.WriteLine(symb2.GetType());
    //    }
    //}
}
