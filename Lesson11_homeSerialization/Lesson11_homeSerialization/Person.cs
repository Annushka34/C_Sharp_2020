using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_homeSerialization
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        private int age;
        public int GetAge
        {
            get=>age;
        }
       
        public Person()
        {

        }
        public Person(string Name, int age)
        {
            this.age = age;
            this.Name = Name;
        }
       
    }
}
