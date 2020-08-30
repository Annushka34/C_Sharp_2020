//using System;
//using System.Threading;

//namespace Lesson
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//           //// if(args.Count() == 0)
//           // {
//           //     Console.WriteLine("no arguments");
//           // }
//           //// else if(args[0] == "-generate")
//           // {
//           //     Console.WriteLine("hello world");
//           //     // Console.Write("kjjkjhkjhkjh");

//           //     double a = 5.5;
//           //     string str = "Hello";
//           //     Console.WriteLine($"gggg  55{str}55  {a} "); // !!!
//           //     Console.WriteLine(String.Format("hhhh {1}wwww {0}oooo", a, str));
//           //     Console.WriteLine("hello" + a + "world   " + str);

//           //     //snipped
//           //     string str1 = Console.ReadLine();
//           //     Console.WriteLine(str1);

//           //    // int b = int.Parse(str1);//  exception if not int
//           //     //char ch = char.Parse(str1);

//           //     // 
//           //     int.TryParse(str1, out int myVar);
//           //     Console.WriteLine(myVar);

//           //     double.TryParse(str1, out double myDVar);
//           //     Console.WriteLine(myDVar);

//           //     //char ch1 = (char)Console.Read();//   Один символ

//           //     Console.WriteLine("Press any key: ");
//           //     ConsoleKeyInfo consoleKeyInfo =  Console.ReadKey();
//           //     Console.WriteLine($"you press: {consoleKeyInfo.KeyChar}");

//           //     ConsoleKey key = consoleKeyInfo.Key;
//           //     switch(key)
//           //     {
//           //         case ConsoleKey.UpArrow:
//           //             Console.WriteLine("up");
//           //             break;
//           //     }

//           //     var d = 5;
//           //     int[] arr = { 5, 3, 6, 10 };

//           //     foreach (var item in arr)
//           //     {
//           //         Console.Write($"{item}   ");
//           //     }
//           //     Console.WriteLine();
//           //     for (int i = 0; i < arr.Length; i++)
//           //     {
//           //         Console.Write($"[{i}]   {arr[i]}");
//           //     }


//           //     //   RANDOM

//           //     Random r = new Random();
//           //     for (int i = 0; i < arr.Length; i++)
//           //     {
//           //         arr[i] = r.Next(0, 15);
//           //     }
//           //     Console.WriteLine();
//           //     foreach (var item in arr)
//           //     {
//           //         Console.Write($"{item}   ");
//           //     }
//           //     Console.WriteLine();


//                //   DATE TIME
//                DateTime dt = new DateTime(2020,12,25, 18, 30, 15);
//                Console.WriteLine(dt.DayOfWeek);
//                DateTime dt2 = new DateTime(2020, 12, 20);
//                dt = dt.AddDays(1);// додати день

//                TimeSpan ts = dt - dt2;//  різниця двох дат
//                Console.WriteLine($"total days diff: { ts.TotalDays}");

//                Console.ForegroundColor = ConsoleColor.Red;

//            for (int i = 0; i < 100; i++)
//            {
//                Console.Clear();
//                Console.WriteLine(DateTime.Now);
//                Thread.Sleep(100);
//            }
//                Console.ResetColor();
//            }
//           // else
//           // {
//            //    Console.WriteLine("START GAME");
//           // }

           


//       // }
//    }
//}
