using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqXML
{
    class Objects
    {
        Student student1 = new Student("Vasja", "gg", 20);
        Student student2 = new Student {Name = "Vass", Surname = "khghg", Age = 32 };
        List<Student> st = new List<Student>
        {
            new Student {Name = "Vass", Surname = "khghg", Age = 32 },
             new Student {Name = "Vass", Surname = "khghg", Age = 32 }
        };
        public void Run()
        {
            CreateAnonimousType();
        }
        public void CreateAnonimousType()
        {
            var st1 = new
            {
                Name = "vass",
                Surname = "hgjhg",
                Age = 30
            };
            var user = new { Name = "Tom", Age = 34 };
            Console.WriteLine(user.Name);
            var st3 = new[]
            {
                new { Name = "Tom", Age = 34 },
                new { Name = "Vasja", Age = 18 }
            }.ToList();
            st3.Add(new { Name = "Olga", Age = 20 });
            var st4 = from p in st3 where p.Age<30 select p;
            foreach(var p in st4)
            Console.WriteLine(p.Name);
        }
       
    }

    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Student()
        {

        }
        public Student(string Name, string Surname, int Age)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Age = Age;
        }

    }
}
