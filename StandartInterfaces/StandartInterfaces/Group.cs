using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StandartInterfaces
{
    class Group : IEnumerable, ICloneable
    {
        public Student TeamLead { get; set; }
        private Student [] Students { get; set; }
        private string GroupName { get; set; }

       

        public Group(string name)
        {
            TeamLead = new Student();
            GroupName = name;
            Students = new Student[]
            {
                new Student{Age = 20, Name = "Ivanov"},
                new Student{Age = 32, Name = "Petrov"},
                new Student{Age = 18, Name = "Pupkin"},
                new Student{Age = 15, Name = "Sidorov"},
                new Student{Age = 45, Name = "Kuk"}
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new MyEnumerator(Students);
        }

        //public IEnumerator GetEnumerator()
        //{
        //    return Students.GetEnumerator();
        //}

        public void DeleteStudent(int ind)
        {
            Students[ind].IsActive = false;
        }    
        
        public void Sort()
        {
            Array.Sort(Students);
        }

        public void SortByAge()
        {
            Array.Sort(Students, new MyCompareByAge());
        }

        public object Clone()
        {
            Group g = new Group(this.GroupName);
            g.GroupName = this.GroupName;
            g.TeamLead = new Student();
            g.TeamLead.Name = this.TeamLead.Name;
            g.TeamLead.Age = this.TeamLead.Age;
            g.Students = new Student[this.Students.Length];
            for (int i = 0; i < this.Students.Length; i++)
            {
                g.Students[i] = new Student();
                g.Students[i].Name = this.Students[i].Name;
                g.Students[i].Age = this.Students[i].Age;
            }
            return g;
        }
    }

    class MyEnumerator : IEnumerator
    {
        int _pos;
        Student[] _students;
        public MyEnumerator(Student []students)
        {
            _students = students;
            _pos = -1;
        }
        public object Current
        {
            get
            {
                if (_pos < _students.Length)
                {
                    if (_students[_pos].IsActive)
                        return _students[_pos];
                    return null;
                }
                else
                {
                    return null;
                }
            }
          
        }

        public bool MoveNext()
        {
            if (_pos < _students.Length)
            {
                _pos++;
            }
            return _pos < _students.Length;
        }

        public void Reset()
        {
            _pos = -1;
        }
    }
}
