using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4_Perevantazennja
{
    class MyCollection
    {
        int[] salaries;
        string[] names;
        public MyCollection(int size)
        {

            salaries = new int[size];
            Random r = new Random();
            for (int i = 0; i < size; i++)
            {
                salaries[i] = r.Next(0, 100);
            }

            names = new string[]
            {
                "Ivanov","Petrov","Sidorov"
            };
        }

        public int this[int i]
        {
            get => salaries[i];
            set => salaries[i] = value;
        }

        public int this[string n]
        {
            get
                {
                int index = -1;
                for (int i = 0; i < names.Length; i++)
                {
                    if(names[i] == n)
                    {
                        index = i;
                    }

                }
                if(index != -1)
                {
                    return salaries[index];
                }
                return 0;
            }
        }

        public int this[int a, int b]
        {
            get
            {
                int sum = 0;
                if(a <0 || b >= salaries.Length)
                {
                    return 0;
                }

                for (int i = a; i <= b; i++)
                {
                    sum += salaries[i];
                }

                return sum;
            }
        }


        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < salaries.Length; i++)
            {
                result += salaries[i].ToString();
                result += " ";
            }
            return result;
        }
    }
}
