using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_Linq
{
    public class User
    {
        public string Name;
        public string Firm;
        public int Age;
    }
    public class LingExample
    {
        //rez = from -var- in -source- select -var-
        int[] arr = new int[12] { 2, 2, 4, 4, 4, 400, 2, 2, 3,5,12,15 };
        List<User> users = new List<User>
        {
            new User{Name="Vasilij", Firm = "Consulting", Age = 20},
            new User{Name="Irina", Firm = "STEP", Age = 19},
            new User{Name="Katerina", Firm = "STEP", Age = 19},
            new User{Name="Vitalij", Firm = "Consulting", Age = 16},
            new User{Name="Max", Firm = "STEP", Age = 25},
            new User{Name="Den", Firm = "STEP", Age = 19}
        };

        //  простий select повертає (можливо іншого типу) колекцію того ж розміру
        public void Select1()
        {
            //  1 linq
            IEnumerable<int> rez = from x in arr select x;
            arr[2] = 100;
            foreach(var x in rez)
            {
                Console.Write(x+" ");
            }
            Console.WriteLine();

            IEnumerable<int> rez1 = (from x in arr select x).ToList();
            arr[2] = 255;
            foreach (var x in rez1)
            {
                Console.Write (x+" ");
            }
            Console.WriteLine();

            //------ extentions methods --------------------------------------
            IEnumerable<int> rez2 = arr.Select(x => x);

            //string str = "hgjhg";
            //str[0];
            //str.First();
            //str.Take(1);

            IEnumerable<int> result = users.Select(x => x.Age);
           // var result = users.Select(x => x.Age);
            foreach (var user in result)
            {
                Console.WriteLine(user);
            }
        }

        public void DistinctEx()
        {
            IEnumerable<int> result = users.Select(x => x.Age).Distinct();
            foreach (var user in result)
            {
                Console.WriteLine(user);
            }
        }

        // select в комбынації з where (умова) - обирає лише ті які відповідають умові і формує колекцію (можливо іншого типу)
        public void Select2()
        {
            IEnumerable<int> rez = from x in arr where x <= 100 select x;
            arr[2] = 100;
            foreach (var x in rez)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            //--------------------------------------------
            //Func<int, bool> GreaterThanTwo3 = delegate (int x) { return x > 2; };
            //Func<int, bool> GreaterThanTwo2 = (x) => { return x > 2; };
            //Func<int, bool> GreaterThanTwo1 = x => { return x > 2; };
            //Func<int, bool> GreaterThanTwo = x => x > 2;

          //  IEnumerable<int> rez3 = arr.Where(GreaterThanTwo3);
            //IEnumerable<int> rez4 = arr.Where(x => x > 2);

            //foreach (int i in rez3)
            //    Console.WriteLine(i);
            IEnumerable<int> rez2 = arr.Where(x => x < 10).Select(x => x);
        }

        //  сортування
        public void Select3()
        {
            IEnumerable<int> rez = from x in arr where x < 10 orderby x descending select x;
            arr[2] = 100;
            foreach (var x in rez)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            //--------------------------------------------

            IEnumerable<int> rez2 = arr.Where(x => x < 10).Select(x => x).OrderByDescending(x=>x);
            foreach (var x in rez2)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
        }

        //  групування
        public void SelectGroup()
        {
            IEnumerable<IGrouping<int,int>> rez = from x in arr group x by x%2;
            //--------------------------------------------
            List<IGrouping<int, int>> rez2 = arr.GroupBy(x => x % 2).ToList();
            foreach (IGrouping<int, int> group in rez2)
            {
                Console.WriteLine(group.Key + " - ");
                Console.WriteLine(group.Count());
                foreach (int val in group)
                {
                    Console.Write(val + " ");
                }
                Console.WriteLine();
            }

           // List<IGrouping<int, int>> rez3 = arr.Where(x => x > 10).GroupBy(x => x % 2).Where(g => g.Count() > 2).ToList();
            List<IGrouping<int, int>> rez3 = arr.GroupBy(x => x % 2).Where(g => g.Count() > 2).ToList();

            var groupsByAge = users.GroupBy(x => x.Age);
            foreach (var group in groupsByAge)
            {
                Console.WriteLine(group.Key);//  назва групи
                foreach (var item in group)
                {
                    Console.WriteLine(item.Name + " " +  item.Firm + " " + item.Age);
                }
            }

            var newResult = users.GroupBy(x => x.Age).Select(g => new { age =  g.Key, amount =  g.Count()})
                .OrderBy(x => x.age);

            foreach (var item in newResult)
            {
                Console.WriteLine(item.age+ " " + item.amount);
            }
        }

        // group + where
        public void Select5()
        {
            IEnumerable<IGrouping<int, int>> rez = from x in arr group x by x % 10 into r where r.Count() > 2 select r;
            foreach (var x in rez)
            {
                Console.Write(x.Key + " - ");
                foreach (var y in x)
                    Console.Write(y + " ");
                Console.WriteLine();
            }
            //----------------------------------------------
            IEnumerable<IGrouping<int, int>> rez2 = arr.GroupBy(x => x % 10).Where(r => r.Count() > 2);
        }

        // let
        public void Select6()
        {
            IEnumerable<int> rez = from x in arr
                         let v = x * 100
                         where v >= 500
                         select v;

            IEnumerable<int> rez2 = from x in arr
                                   let v = x % 4
                                   let v1 = x % 100
                                   where v == v1 && v1 > 0
                                   select x;

            foreach (var r in rez2) Console.WriteLine(r);

            var objEmployee = new[] {
                    new { Name="Sachin", EmpID="I001", Salary=800},
                    new { Name="Vijay", EmpID="I002", Salary=400},
                    new { Name="Ashish", EmpID="I003", Salary=250},
                    new { Name="Syed", EmpID="I004", Salary=300},
                    new { Name="Ravish", EmpID="I005", Salary=700}
                };

            var objresult = from emp in objEmployee
                            let totalSalary = objEmployee.Sum(sal => sal.Salary)
                            let avgSalary = totalSalary / 5
                            where avgSalary > emp.Salary
                            select emp;

            foreach (var emp in objresult)
            {
                Console.WriteLine("Student: {0} {1}", emp.Name, emp.EmpID);
            }
            Console.ReadLine();

            //---------------------------------------------------------------------------
            var rez3 = from x in objEmployee
                       let name = x.Name
                       where name[0].Equals('A')
                       select x;
            foreach (var emp in rez3)
            {
                Console.WriteLine("Student: {0} {1}", emp.Name, emp.EmpID);
            }

            //-----------------------------------------------------------------------------
            var names = new string[] { "Dog", "Cat", "Giraffe", "Monkey", "Tortoise" };
            var result =
                from animalName in names
                let nameLength = animalName.Length
                where nameLength > 3
                select animalName;
        }

        //  join
        public void SelectJoin()
        {
            var objEmployee = new [] {
                    new  { Name="Sachin", EmpID="I001", Salary=800, depart = 1},
                    new  { Name="Vijay", EmpID="I002", Salary=400, depart = 1},
                    new  { Name="Ashish", EmpID="I003", Salary=250, depart = 2},
                    new  { Name="Syed", EmpID="I004", Salary=300, depart = 2},
                    new  { Name="Ravish", EmpID="I005", Salary=700, depart = 1}
                };

            var department = new []
            {
                new { Name = "Account", Id = 1},
                new { Name = "Secretery", Id = 2}
            };

            var rez = from dep in department
                      join empl in objEmployee
                      on dep.Id equals empl.depart into rezDepEmpl
                      from r in rezDepEmpl
                      select r;

            foreach (var r in rez)
            {
                Console.WriteLine(r.Name + " " + r.Salary + " " + (from d in department where d.Id == r.depart select d).SingleOrDefault().Name);
            }

            // -------------------------------------------------
             var result2 = objEmployee.Join(department, // второй набор
             p => p.depart, // свойство-селектор объекта из первого набора
             x => x.Id, // свойство-селектор объекта из второго набора
             (p, x) => new { UserName = p.Name, DepartName = x.Name }); // результат

            foreach (var item in result2)
            {
                Console.WriteLine(item.DepartName+" "+item.UserName);
            }

        }
        //  group join

        //class Depart
        //{
        //    public string Name;
        //    public int Id;
        //}
        //class Empl
        //{
        //    public string Name;
        //    public int depart;
        //    public string EmpID;
        //    public int Salary;
        //}

        //   join + select new
        public void Select8()
        {
            var objEmployee = new[] {
                    new { Name="Sachin", EmpID="I001", Salary=800, depart = 1},
                    new { Name="Vijay", EmpID="I002", Salary=400, depart = 1},
                    new { Name="Ashish", EmpID="I003", Salary=250, depart = 2},
                    new { Name="Syed", EmpID="I004", Salary=300, depart = 2},
                    new { Name="Ravish", EmpID="I005", Salary=700, depart = 1}
                };

            var department = new[]
            {
                new{ Name = "Account", Id = 1},
                new{ Name = "Secretery", Id = 2}
            };

            var rez = from dep in department
                      join empl in objEmployee
                      on dep.Id equals empl.depart into rezDepEmpl
                      from r in rezDepEmpl
                      select new { Dep = dep.Name, Empl = r.Name, Sal = r.Salary};

            foreach (var r in rez)
            {
                Console.WriteLine(r.Dep + " " + r.Empl + " " + r.Sal);
            }
        }

        //  inner select
        public void Select9()
        {
            var objEmployee = new[] {
                    new { Name="Sachin", EmpID="I001", Salary=800, depart = 1},
                    new { Name="Vijay", EmpID="I002", Salary=400, depart = 1},
                    new { Name="Ashish", EmpID="I003", Salary=250, depart = 2},
                    new { Name="Syed", EmpID="I004", Salary=300, depart = 2},
                    new { Name="Ravish", EmpID="I005", Salary=700, depart = 1}
                };
           
            var rez = from e in objEmployee
                      where e.Salary == (from empl in objEmployee
                                                   select empl)
                                                   .Min(x => x.Salary)
                      select e.Name;

            foreach (var r in rez) Console.WriteLine(r);
        }
        class Firm
        {
            public string FirmName;
            public List<User> _users;
        }

        public void SelectManyEx()
        {
            var groups = new List<Firm>
            {
                new Firm
                {
                    FirmName = "STEP",
                    _users = new List<User>
                    {
                            new User{Name="Vasilij", Age = 20},
                            new User{Name="Irina", Age = 19},
                            new User{Name="Katerina", Age = 19},
                            new User{Name="Vitalij",  Age = 16},
                            new User{Name="Max", Age = 25},
                            new User{Name="Den", Age = 19}
                    }
                },
                 new Firm
                {
                    FirmName = "DisignCo",
                    _users = new List<User>
                    {
                            new User{Name="Achmed", Age = 20},
                            new User{Name="Rashid", Age = 19},
                            new User{Name="Asad", Age = 19},
                            new User{Name="Alli",  Age = 16}
                    }
                }
            };

            var users = groups.SelectMany(x => x._users);

            foreach (var item in users)
            {
                Console.WriteLine(item.Name);
            }
        }

        public void Agrerate()
        {
            var str = users.Select(x => x.Name).Aggregate((x, y) => (x + "," + y));
            Console.WriteLine(str);
        }

        public void Another()
        {
            var age = users.Average(x => x.Age);
            Console.WriteLine(age);

            var name = users.Max(x => x.Name);
            Console.WriteLine(age);

            users.First(x => x.Name.StartsWith("a"));

            var page1 = users.Skip(0).Take(10);
        }


        //  selectmany
        //  agregate
        //  skip   take
    }
}
