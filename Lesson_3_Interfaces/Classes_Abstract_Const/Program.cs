using Classes_Abstract_Inheritance;
using System;

namespace Classes_Abstract_Const
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Manager firstManager = new Manager();
            Console.WriteLine(firstManager.CalcSalary(20));

            Employee employee = new Manager();
            Student student = new Student();

            AllGoDrinkCoffe(employee);
            AllGoDrinkCoffe(student);

            ICoffeable student2 = new Manager();
            (student2 as Manager)?.Work2HourMore();

            //Company[] company = new Company[2];
            //company[0] = new PAT();
            //company[1] = new VAT();

            Company[] company = new Company[]
            {
                new PAT(),
                new VAT()
            };

            for (int i = 0; i < 2; i++)
            {
                company[i].SetDevidents();
            }

            //Array.Resize(ref company, 3);

            //for (int i = 0; i < 2; i++)
            //{
                // is
                // as
                //if (company[i] is PAT)//  якщо обэкт типу PAT
                //{
                //    (company[i] as PAT).AddEmployee(); //  приведи обєкт до типу PAT
                //}
                //if (company[i] is VAT)
                //{
                //    (company[i] as VAT).AddNewDirectorToVAT();
                //}

                //PAT p = company[i] as PAT;
                //p?.AddEmployee();
                //if(p != null)
                //{
                //    p.AddEmployee();
                //}

            //}
        }


        static void ShowSmth(Company company)
        {
            //   якщо ссилка типу Компані (базового класу) показує
            //   на обєкт типу PAT то виклич метод AddEmployee
            (company as PAT)?.AddEmployee();//company as PAT  не null? то виклич метод
        }


        static void AllGoDrinkCoffe(ICoffeable coffeable)
        {
            Console.WriteLine("COFFEE BREAK");
            coffeable.DrinkCofee();
        }
    }
}
