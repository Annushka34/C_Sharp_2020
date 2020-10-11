using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9_Delegats
{
    class CommonDelegates
    {
        public void Start()
        {
            List<string> myList = new List<string>
            {
                "milk","bread","butter","cheese","yougurt"
            };
            myList.ForEach(ShowAdv);
            //  анонімний delegate
            //  delegate (параметри) { код ;}
            myList.ForEach(delegate (string n) { Console.WriteLine("Anonymus delegate: " + n); });

            //   лябда делегат
            myList.ForEach((string n) => { Console.WriteLine("Anonymus delegate: " + n); });
            myList.ForEach( n => { Console.WriteLine("Anonymus delegate: " + n); });

            myList.ForEach(n => Console.WriteLine(n));
        }

        public void FuncExample()
        {
            ///  перші параметри це те що приймає метод, останній - те що повертає
            Func<int, int, int, string> simpleFunc = FuncExMethod;
            simpleFunc(5, 13, 8);

            List<string> myList = new List<string>
            {
                "milk","bread","apple","butter","cheese","yougurt"
            };

            var newCollection = myList.Select(SelectStartA);
            foreach (var item in newCollection)
            {
                Console.WriteLine(item);
            }

            var newCol = myList.Select(delegate (string n) { return n + "..."; });
            var newCol2 = myList.Select((string n) => { return n + "..."; });
            var newCol3 = myList.Select(x => x + "...");
        }

        public void PredicateExample()
        {
            ///  приймає один параметр і повертає bool
            Predicate<int> simplePred = PredExMethod;
            simplePred(5);

            List<string> myList = new List<string>
            {
                "milk","bread","apple","butter","cheese","yougurt", "ananas"
            };

            List<string> myListNew =  myList.Where(ForPredicate).ToList();
            IEnumerable<string> myListNew2 = myList.Where(x => x.StartsWith("b"));

            foreach (var item in myListNew2)
            {
                Console.WriteLine(item);
            }
        }

        bool ForPredicate(string str)
        {
            //if(str.StartsWith("a") == true)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            return str.StartsWith("a");
        }

        void ActionExample()
        {
            Action <string> action = ShowAdv;
            action("Youtube");
        }

    

        string SelectStartA(string n)
        {
            return n + "...";
        }

        

        void ComparExample()
        {
            ///  приймає два параметри і повертає int
            Comparison<int> simpleComp = CompExMethod;
            simpleComp(5, 10);
        }

        int CompExMethod(int x, int y)
        {
            return x.CompareTo(y);
        }

        bool PredExMethod(int x)
        {
            return x > 0;
        }

        string FuncExMethod(int x, int y, int z)
        {
            return x.GetType().Name;
        }

        void ShowAdv(string adv)
        {
            Console.WriteLine(adv+"......started");
        }
      

        /// <summary>
        /// приймає в параметрах метод який треба запустити
        /// </summary>
        /// <param name="act"></param>
        public void StartGame(Action act)
        {
            ///  запускаЄ той метод який прийде в параметрах
            act();
        }
    }
}
