using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex123
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^\d$";
            string pattern2 = @"^\d*$";
            string pattern3 = @"^[0-9]*$";
            //12-45-56
            string pattern4 = @"^[0-9]{2}-[0-9]{2}-[0-9]{2}$";
            //
            string pattern5 = @"^a.*a$";
            string pattern6 = @"<img>(.*)</img>";

            string str = Console.ReadLine();
            Regex r = new Regex(pattern6);
            if(r.IsMatch(str))
            {
                Console.WriteLine("Рядок відповідає шаблону");
            }
            else
            {
                Console.WriteLine("Рядок не валідний");
            }
            str = @"<img>photo.img</img>";
            MatchCollection mc = r.Matches(str);
            Console.WriteLine(mc[0].Groups[1]);
        }
    }
}
