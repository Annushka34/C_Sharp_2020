//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lesson_9_Delegats
//{
//    public delegate void CalcDeleg();
//    public delegate int SumMinDel(int x, int y);
//    class Program
//    {
      
//        static void Main(string[] args)
//        {
//            CalcDeleg calcDeleg = Show;//   ініціалізували
//            calcDeleg += Print;//   додали
//            calcDeleg += Print;//   додали
//            calcDeleg += Print;//   додали


//            calcDeleg();//   виклик

//            Delegate[] methods =  calcDeleg.GetInvocationList();
//            for (int i = 0; i < methods.Length; i++)
//            {
//                //    назва методу який лежить в делегаті
//                Console.WriteLine(methods[i].Method.Name);
//                //   запусе - виконання методу
//                methods[i].DynamicInvoke();
//            }

//            SumMinDel sumMinDel = Sum;
//            sumMinDel += Min;

//            //int res =  sumMinDel(10, 15);// result only from last method
//            //Console.WriteLine(res);


//            foreach (var item in sumMinDel.GetInvocationList())
//            {
//               int res = (int)item.DynamicInvoke(10, 15);
//                Console.WriteLine(res);
//            }
//        }

//        static void Print()
//        {
//            Console.WriteLine("------------------------");
//        }

//        static void Show()
//        {
//            Console.WriteLine("**************************");
//        }


//       static int Sum(int x, int y)
//        {
//            Console.WriteLine("Sum");
//            return x + y;
//        }

//        static int Min(int x, int y)
//        {
//            Console.WriteLine("Min");
//            return x - y;
//        }
//    }
//}
