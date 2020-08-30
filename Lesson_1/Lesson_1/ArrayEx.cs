using System;

namespace Lesson_1
{
    class ArrayEx
    {
        static void Main(string[] args)
        {
            int size = 10;
            int[] arr = new int[size];
            Array.Resize(ref arr, 12);

            int a = 0;
            RefMethod(ref a);
            Console.WriteLine(a);

            ParamsMethod(5, 10, 13);
            Console.WriteLine();

            ParamsMethod(5);

            ChangeArr(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }


            //   неімовані маси


            //    масиви object


            //    двовимірні масиви
        }


        static void ChangeArr(int [] arr)
        {
            arr = new int[15];
            arr[0] = 122;
        }

        /// <summary>
        /// method wich get param by reference
        /// </summary>
        static void RefMethod(ref int a, int b = 15)
        {
            a = 10;
        }

        static void OutMethod(out int a)
        {
            a = 15;
        }

        static void ParamsMethod(params int [] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }
        }


        static void Line()
        {
            Console.WriteLine();
        }
    }
}
