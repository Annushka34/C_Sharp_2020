using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15Linq
{
    class LinqInt
    {
        int[] arr = new int[10] { 2, 5, 7, 8, 9, 6, 4, 5, 10, 12 };

        List<Point> p = new List<Point>
            {
                new Point{Name = "Start", X = 0, Y = 0},
                new Point{Name = "Mid1", X = 10, Y = 0},
                new Point{Name = "Mid2", X = 20, Y = 10},
                new Point{Name = "End", X = 30, Y = 30}
            };

        public void Select1()
        {
            IEnumerable<int> rez = from x in arr select x;
            foreach (var r in rez)
            {
                Console.Write($"{r} ");
            }
            arr[5] = 100;
            Console.WriteLine();
            foreach (var r in rez)
            {
                Console.Write($"{r} ");
            }
            Console.WriteLine();

            List<int> rez1 = (from x in arr select x).ToList();
            foreach (var r in rez1)
            {
                Console.Write($"{r} ");
            }
            arr[5] = 0;
            Console.WriteLine();
            foreach (var r in rez1)
            {
                Console.Write($"{r} ");
            }

            Func<int, int> del = delegate (int x) { return x * 10; };
            Func<int, int> del1 = (x) => x * 10;
            Func<int, int> del3 = x => x * 10;
            IEnumerable<int> rez2 = arr.Select(del3);
            IEnumerable<int> rez3 = arr.Select(x => x * 10);
            IEnumerable<int> rez4 = arr.Select(x => x);

            //-----Обираємо всі імена з колекції точок (формується колекція імен(стрінг))
            IEnumerable<string> rezNames = p.Select(x => x.Name);
        }
        public void Select2()
        {
            IEnumerable<int> rez = from x in arr where x > 10 select x;
            IEnumerable<int> rez1 = arr.Where(x => x > 10).Select(x => x);
            //---обрати імена нточок з ненульовими координатами
            IEnumerable<string> rezNames = p.Where(x => x.X != 0 && x.Y != 0).Select(x => x.Name);
        }
    }

    class Point
    {
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

    }
}
