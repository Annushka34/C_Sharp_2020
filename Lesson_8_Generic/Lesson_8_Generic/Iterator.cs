using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_Generic
{
    public static class IteratorMain
    {
        public static void ShowArmy()
        {
            Army army = new Army();
            foreach (var item in army.GetArcher())
            {
                Console.WriteLine(item);
            }
        }
    }

    class Unit
    {
        public string name;
        public override string ToString()=> name;
    }

    class Army 
    {
       
        public Unit[] units = new Unit[]
        {
            new Unit{ name = "Archer_1"},
            new Unit{ name = "Mag_1"},
            new Unit{ name = "Swordsman_1"},
            new Unit{ name = "Mag_2"},
            new Unit{ name = "Swordsman_2"},
            new Unit{ name = "Archer_2"},
            new Unit{ name = "Archer_3"},
            new Unit{ name = "Archer_4"}
        };

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < units.Length; i++)
            {
                yield return units[i];
            }
        }

        public IEnumerable GetArcher()
        {
            for (int i = 0; i < units.Length; i++)
            {
                if(units[i].name.Contains("Archer"))
                    yield return units[i];
            }
        }
    }
}
