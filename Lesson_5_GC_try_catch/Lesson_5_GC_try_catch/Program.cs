using System;

namespace Lesson_5_GC_try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            try
            {
                p.Method1();
                Console.WriteLine("Main");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
            }
            finally
            {
                Console.WriteLine("Close file!");
            }
            string name = Console.ReadLine();
            if(name == "Vas")
            {
               // throw new MyEx("Vas is blocked");
                throw new MyEx();
            }
        }


    }
}
