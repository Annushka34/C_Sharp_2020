using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {

        static void Main(string[] args)
        {
            List<User> departament = new List<User>
            {
                new User("Ivanov", 30),
                new User("BiliChoboty", 20),
                new User("SiniBrovi", 15),
                new User("Pupkina", 18),
                new User("Petrovna", 36),
                new User("Zuk-zuk", 24)
            };

            IEnumerable<User> oldUsers = departament.Where(x => x.age > 20).ToList();

            departament[3].age = 99;
            Show(oldUsers, "WHERE");

            departament[3].age = 10;
            Show(oldUsers, "WHERE");

            IEnumerable<string> studentsStr = departament.Select(x => x.name +"  student").ToList();
            IEnumerable<Student> students = departament.Select(user => 
                new Student 
                { 
                    name = user.name, 
                    isStudy = user.age > 18 && user.age < 40, 
                    group = "Default"
                })
                .ToList();

            Show<Student>(students, "SELECT STUDENTS FROM USERS");

            var stud = new { Name = "Petrov", Salary = 10000 };
            var studs = new[]
            {
                new { Name = "Petrov", Salary = 10000 },
                new { Name = "Sidorov", Salary = 10000 }
            };

            var studentsAnonim = departament.Select(user =>
              new
              {
                  user.name,
                  isStudy = user.age > 18 && user.age < 40,
                  group = "Default"
              })
              .ToList();

            foreach (var studOne in studentsAnonim)
            {
                Console.WriteLine(studOne.name);
            }

            Show(studentsAnonim, "STUD ANONIM");
        }


    
    static void Show<T>(IEnumerable<T> users, string name)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(name);
        Console.ResetColor();
        foreach (var item in users)
        {
            Console.WriteLine(item);
        }
    }
}

    class User
    {
        public string name;
        public int age;
        public User(string n, int a)
        {
            name = n;
            age = a;
        }

        public override string ToString()
        {
            return name + "   " + age.ToString();
        }
    }

    class Student
    {
        public string name;
        public bool isStudy;
        public string group;

        public override string ToString()
        {
            return name + "   ispotential student " + isStudy.ToString()+"   group: "+ group;
        }
    }
}
