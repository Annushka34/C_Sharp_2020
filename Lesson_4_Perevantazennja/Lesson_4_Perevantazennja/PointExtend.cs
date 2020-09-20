using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4_Perevantazennja
{
    partial class Point
    {
        public static Point operator + (Point p1, Point p2)
        {
            Point pNew = new Point();
            pNew.x = p1.x + p2.x;
            pNew.y = p1.y + p2.y;
            pNew.name = "new sum of points";
            return pNew;
        }

        public static int operator +(int a, Point p2)
        {
            int result = a + p2.x + p2.y;
            return result;
        }

        public static Point operator +(Point p1, int a)
        {
            Point pNew = new Point();
            pNew.x = p1.x + a;
            pNew.y = p1.y + a;
            pNew.name = "new sum of points";
            return pNew;
        }

        public static Point operator ++ (Point p)
        {
            p.x++;
            return p;
        }

        public static bool operator == (Point p, Point p1)
        {            
            return p.x == p1.x && p.y == p1.y;
        }
        public static bool operator !=(Point p, Point p1)
        {
            return !(p == p1);
        }

        public static Point operator >> (Point p, int x)//   Побітовий зсув вправо
        {
            //01100100 = 100
            //>>1
            //00110010 = 50
            p.x = p.x >> x;
            p.y = p.y >> x;
            return p;
        }
    }
}
