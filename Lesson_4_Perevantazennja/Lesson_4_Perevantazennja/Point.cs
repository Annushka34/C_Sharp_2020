using System;

namespace Lesson_4_Perevantazennja
{
    partial class Point
    {
       // private int a;

        //public int A
        //{
        //    //set
        //    //{
        //    //    a = value;
        //    //}

        //    get => a;
        //}
        public int x { set; get; }
        public int y { set; get; }
        public string name { set; get; }
        public Point(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
        public Point()
        {
            Random r = new Random();
            x = r.Next(0, 10);
            y = r.Next(0, 10);
            name = "no name ";
        }

        // public int GetMyPoint() => x + y;

        public static implicit operator Point (int a)
        {
            Point newP = new Point(a, a, "int point");
            return newP;
        }

        public static implicit operator int(Point p)
        {

            int a = p.x + p.y;
            return a;
        }

        public override string ToString()
        {
            return $"name: {name} x: {x} y: {y}";
        }
    }
}
