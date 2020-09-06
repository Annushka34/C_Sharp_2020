using System;
using System.Collections.Generic;
using System.Text;

namespace Part1
{
    class NullCond
    {
        //  nullable
        int? a = default;
        DateTime? date = null;
        Human? h = null;
        Person p = null;

        void Foo(int? b = null)
        {
            // int c = 0;
            //if (b != null)
            //{
            //     c = (int)b;
            //}
            //int c = b != null ? (int)b : 0;
            int c = b ?? 0;//   візьми значення b якщо воно не null або 0
            if(a == null)
            {

            }
        }


        public void TakePerson(Person p)
        {
            // Person p1 = p?? new Person();//  візьми р якщо він не налл, або створи новий
            Person p1 = p;
            p1?.Show();//  виклич метод якщо обєкт не налл
        }
    }

    //struct Human
    //{

    //}

    class Person
    {
        public void Show()
        {
            Console.WriteLine("I am person");
        }
    }
}
