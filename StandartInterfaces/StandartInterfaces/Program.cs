using Calculator;
using System;

namespace StandartInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group("VBU-911");
            group.TeamLead.Name = "Cool manager";

            foreach (Student student in group)
            {
                Console.WriteLine(student);
            }

            //group.DeleteStudent(2);
            //Console.WriteLine();
            //foreach (Student student in group)
            //{
            //    Console.WriteLine(student);
            //}

            Console.WriteLine();
            group.SortByAge();
            foreach (Student student in group)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine(group.TeamLead);

            Group g2 = (Group)group.Clone();
            Console.WriteLine(g2.TeamLead);

            group.TeamLead.Name = "Bad manager";

            Console.WriteLine(group.TeamLead);
            Console.WriteLine(g2.TeamLead);

            CalcService calcService = new CalcService();
            calcService.CalculateNumbers(2, 3);
        }
    }
}
