//using System;
//using System.Diagnostics;
//using System.Text;

//namespace Lesson_1
//{
//    class StringEx
//    {
//        static void Main(string[] args)
//        {
//            //Line();

//            //string str = "......gggg  uuuu   rrr  .hhh eee. lllll....";
//            //String str1 = new string(str.ToCharArray());
//            //string str2 = str1;

//            //// ==
//            //if (str1 == str2)// if (str1.Equals(str2)))
//            //{
//            //    Console.WriteLine("equel");
//            //}

//            ////for (int i = 0; i < 5; i++)
//            ////{
//            ////    var strNew = Console.ReadLine();
//            ////    str1 += strNew;//   new memmory allocated
//            ////    Console.WriteLine(str1);
//            ////}

//            //str1 = "new text";

//            //// StringBuilder !!!!

//            //str = str.Insert(3, "0000");
//            //Console.WriteLine(str);
//            //str = str.Remove(3, 4);
//            //Console.WriteLine(str);

//            //str = str.Replace(' ', '.');
//            //Console.WriteLine(str);
//            //str = str.Trim('.');//   видалити всі входження симовлу
//            //Console.WriteLine(str);
//            //str = str.Insert(2, "/");
//            //str = str.Insert(7, "/");
//            //Console.WriteLine(str);
//            //string[] arrStr = str.Split('/');

//            //for (int i = 0; i < arrStr.Length; i++)
//            //{
//            //    Console.WriteLine(arrStr[i]);

//            //}

//            Stopwatch stopWatch = new Stopwatch();
//            stopWatch.Start();

//            StringBuilder str = new StringBuilder("hello", 10);
//            for (int i = 0; i < 100; i++)
//            {
//                str.Append(".");                
//            }
//            Console.WriteLine(str);

//            //string str = "hello";
//            //for (int i = 0; i < 10000; i++)
//            //{
//            //    str += ".";
//            //}

//            stopWatch.Stop();
//            Console.WriteLine(stopWatch.ElapsedMilliseconds);
            
//        }


//        static void Line()
//        {
//            Console.WriteLine();
//        }
//    }
//}
