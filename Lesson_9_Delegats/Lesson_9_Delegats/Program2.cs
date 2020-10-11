using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9_Delegats
{
    class Program
    {

        static void Main(string[] args)
        {
            //Subscriber gnomon = new Subscriber("Gnomon");
            //List<Subscriber> subscribers = new List<Subscriber>
            //{
            //    new Subscriber("Vasja"),
            //    gnomon,
            //    new Subscriber("Artem"),
            //    new Subscriber("Irina"),
            //    new Subscriber("Vasilina")
            //};

            //NewsSender sender = new NewsSender();

            //foreach (var item in subscribers)
            //{
            //    sender.news += item.GetNew;
            //}

            //sender.news -= gnomon.GetNew;

            //sender.news("Грьобаний коранавІрус");


            CommonDelegates common = new CommonDelegates();
            //common.StartGame(ShowAdvTarget);

           // common.Start();
           // common.FuncExample();
            common.PredicateExample();
        }

        static void ShowAdvStandart()
        {
            Console.WriteLine("adv......started");
        }

        static void ShowAdvTarget()
        {
            Console.WriteLine("target.....started");
        }
    }
}
