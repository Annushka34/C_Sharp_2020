using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_Generic
{
    public static class Extention
    {
        public static void Show(this string str)
        {
            Console.WriteLine("*"+str+"*");
        }

        public static void Show<T>(this IEnumerable<T> arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
