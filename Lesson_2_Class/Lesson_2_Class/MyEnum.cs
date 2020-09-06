using System;

namespace Part1
{
    public enum Month { Sept, Oct, Nov };
    class MyEnum
    {
        public void Set()
        {
            Month september = Month.Sept;
            september = Month.Oct;
            int a = (int)Month.Sept;

            Human h;
            Human h1 = new Human();//  всі поля будуть ініціалізовані дефолтними значеннями

            string[] names = Enum.GetNames(typeof(Month));
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            try
            {
                var october = (Month)Enum.Parse(typeof(Month), "Oct2222");
                Console.WriteLine(october);
            }
            catch
            {
                Console.WriteLine("No such month");
            }
        }
    }


    struct Human
    {
        Month bierthday;
        int a;
        DateTime date;
        public Human(Month m)
        {
            bierthday = m;
            a = default;
            date = default;
        }
    }
}
