#define LESSON1

using System;

namespace Lesson_1
{
    class ArrayEx
    {
        static void Main(string[] args)
        {
#if LESSON1
            int size = 10;
            int[] arr = new int[size];
            int[] arr2 = { 5, 7, 10 };
            int[] arr3 = new[] { 2, 7, 8, 9 };
            Array.Resize(ref arr, 12);
#endif
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

            foreach (var item in arr)// var - сам визначить тип
            {
                Console.WriteLine(item);
            }
            //   неімовані маси
            var arr5 = new[] { 3, 7, 10 };
            var arr6 = new[] { 5.2, 10 };
            var obj = new { Name = "Vasja", Age =  32  };

            //    масиви object
            var arr7 = new object[] {"Vasja", 32, 5.2, true };

            int a4 = 5;
            double a5 = a4;
            int a6 = (int)a5;

            //---затрати на boxing-unboxing
            object a7 = a6;
            int a8 = (int)a7;
            Console.WriteLine(a8);

            //    двовимірні масиви

            int[][] arrTwo = new int[2][];           
            arrTwo[0] = new int[] { 5,7,3};
            arrTwo[1] = new int[] { 5, 7, 3, 10, 15, 3, 6 };


            const int r = 4;
            const int c = 3;
            int[,] arrTwo2 = new int[r, c] { {5, 3, 7 },{ 4, 5, 9 },{ 1,1,1},{2,2,3 } };
            foreach (var item in arrTwo)
            {
                foreach (var i in item)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------------------");
            foreach (var item in arrTwo2)
            {
                Console.Write(item);
            }
            Console.WriteLine("-------------------------------------");

            Console.WriteLine(arrTwo2.Length);
            Console.WriteLine($"rows: {arrTwo2.GetLength(0)}");
            Console.WriteLine($"cols: {arrTwo2.GetLength(1)}");

            //  кількість вимірів
            Console.WriteLine($"rank: {arrTwo2.Rank }");
            // arrTwo2.GetUpperBound - номер останнього рядка
            Console.WriteLine($"GetUpperBound: {arrTwo2.GetUpperBound(0) }");
            // arrTwo2.GetUpperBound - номер останньої колонки
            Console.WriteLine($"GetUpperBound: {arrTwo2.GetUpperBound(1) }");


            //----------------checked - unchecked
            byte b = 255;
            byte b2 = 100;
            byte b1 = checked((byte)(b + b2));

            Console.WriteLine($"255+{b2} in byte: {b1}");
        }


        static void ChangeArr(int[] arr)
        {
            arr = new int[15];
            arr[0] = 122;
        }

#region MethodsParams

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

        static void ParamsMethod(params int[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }
        }
        #endregion

        static void Line()
        {
            Console.WriteLine();
        }
    }
}
