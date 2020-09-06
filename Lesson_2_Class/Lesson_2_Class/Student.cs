using Lesson_2_Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace Part2
{
    internal class Student
    {
        private int age;
        public string name;

        public const string UNIVERSITY = "STEP";// не можна лишити не ініціалізованим
        public readonly int group;

        public static int counter = 0;

        public Student():this(25, "Pupkin", 3)
        {
            Random r = new Random();
            group = r.Next(1, 5);
            //age = r.Next(10, 40);
            counter++;
        }

        public Student(int age, string name, int group): this(age, group)
        {
            this.name = name;
            counter++;
            Console.WriteLine(Settings.DeveloperName);
        }

        public Student(int age, int group)
        {
            this.age = age;
            this.group = group;
            counter++;
        }

        public Student(string name)
        {
            this.name = name;
            group = 3;
            counter++;
        }

        public void SetAge(int age)
        {
            this.age = age;
            this.Show();
        }

        private void Show()
        {
            Console.WriteLine($"Student {age} {name}");
            Mail m = new Mail();
            m.SendMail(this);
        }


        public void SendMeLetter()
        {
            Console.WriteLine($"Letter sended {name}");
        }
    }


    struct Mail
    {
        public void SendMail(Student s)
        {
            s.SendMeLetter();
        }
    }
}
