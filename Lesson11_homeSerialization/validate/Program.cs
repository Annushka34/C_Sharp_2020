using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace validate
{
    class Program
    {
        static void Main(string[] args)
        {
            //f3-j.ghj@dvxv.jfhdf.ua
            //string emailPattern = @"^([a-z0-9_-]+\.)*[a-z0-9_-]+@[a-z0-9_-]+(\.[a-z0-9_-]+)*\.[a-z]{2,6}$";
            //Console.Write("Enter e-mail: ");
            //string email = Console.ReadLine();
            //Regex regex = new Regex(emailPattern);
            //Console.WriteLine(regex.IsMatch(email) ? "E-mail confirmed." : "Incorrect e-mail!");
            //string phonePattern = @"^\+\d{ 2}\(\d{ 3}\)\d{ 3}-\d{ 2}-\d{ 2}$";
            //Console.Write("Enter phone: ");
            //string phone = Console.ReadLine();
            //regex = new Regex(phonePattern);
            //Console.WriteLine(regex.IsMatch(email) ? "Data received." : "Data is not correct!");

            //Console.WriteLine("\nReplacement of words matching a pattern.");
            //string text = "I like Java. Java forever.";
            //string textPattern = "Java";
            //Console.WriteLine(text);
            //Console.WriteLine(Regex.Replace(text, textPattern, "C#"));

            //string pattern = @"^(\([0-9a-zA-Z]*\))\.([a-zA-Z]+)$";
          //  string str = Console.ReadLine();
            //Regex r = new Regex(pattern);
            //if (r.IsMatch(str)) Console.WriteLine("good");
            ////string teg = @"^<input>.</input>$";
            ////string str1 = "<input>Ann</input>";
            ////string pat1 = "(<[/]?input>)(.*)([/]?input>)";
            ////string pat = "([^<>]*)";

            ////Regex r1 = new Regex(str);
            ////if (r1.IsMatch(str))
            ////{
            ////    Console.WriteLine("!");
            ////    //str1 = Regex.Replace(str1, pat, "");
            ////}
            ////Console.WriteLine(str);
            //MatchCollection m = r.Matches(str);

            ////foreach (var item in m)
            ////{
            ////    Console.WriteLine(item);
            ////}

            //for (int i = 0; i < m.Count; i++)
            //{
            //    foreach (var j in m[i].Groups)
            //        Console.WriteLine(j);
            //}
            var str = "<div>some text<p>text</p>end <b>t</b>ext</div>";
            string pattern = @"<[/]?div>(.*)<[/]?p>(.*)<[/]?div>";
            var m = Regex.Matches(str, pattern);
            str = Regex.Replace(str, pattern, "tag");
            ////Match m = Regex.Match(str, pattern);
            //for (int k = 0; k < m.Count; k++)
            //{
            //    Console.WriteLine(m[k].Value);
            //    for (int i = 0; i < m[k].Groups.Count; i++)
            //    {
            //        Console.WriteLine("Group: " + i);
            //        Console.WriteLine(m[k].Groups[i].Value);
            //        for (int j = 0; j < m[k].Groups[i].Captures.Count; j++)
            //        {
            //            Console.WriteLine("Capture: " + j);
            //            Console.WriteLine(m[k].Groups[i].Captures[j].Value);
            //        }
            //    }
            //    Console.WriteLine();
            //}
            Console.WriteLine(str);
            //Console.WriteLine("Enter numbers");
            //string str5=Console.ReadLine();
            //string pattern2 = @"^\d*$";
            //Regex r5 = new Regex(pattern2);
            //if(r5.IsMatch(str5))
            //{
            //    Console.WriteLine("numbers");
            //}

            //string input = "/content/alternate-1.aspx";
            //Match match = Regex.Match(input, @"content/([A-Za-z0-9\-]+)\.aspx$",
            //RegexOptions.IgnoreCase);
            //if (match.Success)
            //{
            //    string key = match.Groups[1].Value;
            //    Console.WriteLine(key);
            //}
            ////----------------------------------------------
            //string value = "4 AND 5";

            //// Get first match.
            //Match match5 = Regex.Match(value, @"\d");
            //if (match5.Success)
            //{
            //    Console.WriteLine(match5.Value);
            //}

            //// Get second match.
            //match5 = match5.NextMatch();
            //if (match.Success)
            //{
            //    Console.WriteLine(match5.Value);
            //}
            ////------------------------------------------------------
            //Match m6 = Regex.Match("456 Oggggga 456 Odddda", @"(O\D*a)");
            //if (m6.Success)
            //{
            //    Console.WriteLine("Value  = " + m6.Value);
            //    Console.WriteLine("Length = " + m6.Length);
            //    Console.WriteLine("Index  = " + m6.Index);
            //}

            //m6=m6.NextMatch();
            //if (m6.Success)
            //{
            //    Console.WriteLine("Value  = " + m6.Value);
            //    Console.WriteLine("Length = " + m6.Length);
            //    Console.WriteLine("Index  = " + m6.Index);
            //}
            ////--groups
            //MatchCollection m7 = Regex.Matches("456 Oggggga 456 Odddda", @"(O\D*a)");
            //Console.WriteLine(m7[0].Groups[0].Value);
            //Console.WriteLine(m7[1].Groups[0].Value);

            ////-------------------------------------------------------
            //const string val = "IRINA";
            //if (Regex.IsMatch(val, "ir...", RegexOptions.IgnoreCase))
            //{
            //    Console.WriteLine(true);

            //}
        }
    }
}
