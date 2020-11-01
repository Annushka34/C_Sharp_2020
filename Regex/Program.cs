using System;
using System.Text.RegularExpressions;

namespace Regex123
{
    class Program
    {
        static void Main(string[] args)
        {
          //  string pattern = @"^.a.*$";
            //string pattern = @"^0\d{2}-\d{3}-\d{2}-\d{2}$";
            //Regex r = new Regex(pattern);
            //while (true)
            //{
            //    string str = Console.ReadLine();
            //    Console.WriteLine(r.IsMatch(str));
            //}

            //
            //string pattern2 = @"^\d*$";
            //string pattern3 = @"^[0-9]*$";
            ////12-45-56
            //string pattern4 = @"^[0-9]{2}-[0-9]{2}-[0-9]{2}$";
            ////
            //string pattern5 = @"^a.*a$";
            string pattern6 = @"<img>(.*)(\.\w{2,5})</img>";

          //  string str = Console.ReadLine();
            Regex r = new Regex(pattern6);
            string str = @"fdgdfgd<img>photo.img</img>dfgdfgdg";

            if (r.IsMatch(str))
            {
                Console.WriteLine("Рядок відповідає шаблону");
            }
            else
            {
                Console.WriteLine("Рядок не валідний");
            }
            MatchCollection mc = r.Matches(str);
            Console.WriteLine(mc[0].Groups[1]);
            Console.WriteLine(mc[0].Groups[2]);
        }
    }
}
