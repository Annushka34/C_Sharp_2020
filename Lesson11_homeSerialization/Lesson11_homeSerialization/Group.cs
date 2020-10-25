using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_homeSerialization
{
    [Serializable]
    public class Group
    {
        public List<Student> students;
        
        public Group()
        {
           
        }
        public void Create()
        {
            students = new List<Student>
            {
                new Student{Name="Ivan",Surname="Ivanov"},
                new Student("Petro",25,"Petrov")
            };
        }
        public void ShowGroup()
        {
            foreach(Student student in students)
            {
                student.Show();
            }
        }
    }
}
