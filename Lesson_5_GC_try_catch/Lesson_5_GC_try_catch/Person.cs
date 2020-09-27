using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Lesson_5_GC_try_catch
{
    class Person
    {
        public void Method1()
        {
            FooWithException();

            Console.WriteLine("Program continue...");
            for (int i = 0; i < 20; i++)
            {
                Console.Write(".");
                Thread.Sleep(50);
            }
        }


        void FooWithException()
        {
            int x = 10;
            int y = 0;
            try
            {
                string str = Console.ReadLine();
                y = int.Parse(str);
                // y = Convert.ToInt32(str);
                int a = x / y;
                Console.WriteLine("a = " + a);

                int[] arr = { 5, 7, 3 };
                if (y < 0 || y >= 3)
                {
                    throw new Exception("Index can't be less zero and more than 3");
                }
                for (int i = y; i < 3; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Can't parse format");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message+"!!!!", e);
                //Console.WriteLine("Error");
                //Console.WriteLine(e.Message);
                //Console.WriteLine("Stack trace: ");
                //Console.WriteLine(e.StackTrace);//line error                
            }
            catch { }
        }
    }
}
