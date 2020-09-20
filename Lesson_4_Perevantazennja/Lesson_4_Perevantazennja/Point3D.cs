using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4_Perevantazennja
{
    class Point3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public string Name { get; set; }

        public static implicit /*неявне*/ operator Point3D (Point p)// explicit
        {
            Point3D newP = new Point3D();
            newP.X = p.x;
            newP.Y = p.y;
            newP.Z = 0;
            newP.Name = p.name;
            return newP;
        }

        public override string ToString()
        {
            return $"name: {Name} x: {X} y: {Y}  z: {Z}";
        }
    }
}
