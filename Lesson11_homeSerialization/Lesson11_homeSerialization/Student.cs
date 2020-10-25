using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_homeSerialization
{
    [Serializable]
    public class Student:Person
    {
        [NonSerialized]
        public string GroupName;
        [NonSerialized]
        public string Surname;
        public Student()
        {

        }
        public Student(string Name, int age, string Surname):base(Name, age)
        {
            this.Surname = Surname;
            GroupName = "programmers";
        }
        public void Show()
        {
            Console.WriteLine(GroupName);
            Console.WriteLine($"{Name} {Surname} {GetAge}");
        }
    }
}
