using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9_Delegats
{
    public delegate T MyDel<T>(T x, T y);
    class TempalteDelegate
    {
        void Start()
        {
            MyDel<int> myDel = Sum;
            MyDel<char> myDel2 = SumChars;
        }

        int Sum(int x, int y)
        {
            Console.WriteLine("Sum");
            return x + y;
        }

        char SumChars(char x, char y)
        {
            Console.WriteLine("Sum");
            return (char)(x + y);
        }
    }



}
