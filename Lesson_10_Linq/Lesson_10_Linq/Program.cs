//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lesson_10_Linq
//{
//    class Program
//    {
       
//        static void Main(string[] args)
//        {
//            EventExample eventExample = new EventExample();
//            eventExample.calc += CalcSum;
//            eventExample.calc += CalcMin;


//            eventExample.Start();

//            eventExample.calc -= CalcSum;
//            eventExample.calc -= CalcMin;
//            eventExample.Start();
//        }

//        private static void CalcSum(int x, int y)
//        {
//            Console.WriteLine(x + y);
//        }

//        private static void CalcMin(int x, int y)
//        {
//            Console.WriteLine(x - y);
//        }
//    }
//}
