using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StandartInterfaces
{
    class Student : IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsActive { get; set; } = true;

      

        public int CompareTo(object obj)
        {
            return this.Name.CompareTo((obj as Student).Name);
          
        }

        public override string ToString()
        {
            return $"{Name} {Age}";
        }
    }

    class MyCompareByAge : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x.Age > y.Age)
            {
                return 1;
            }
            if(x.Age < y.Age)
            {
                return -1;
            }
            return 0;
        }
    }

    class MyCompareByName : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
