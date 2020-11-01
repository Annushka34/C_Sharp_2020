using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface MyIntarface
    {
        string Hello();
    }

    public class Flower
    {
        public void ShowFlower ()
        {
            Console.WriteLine("Im flower\n");
        }

        public void ShowTree(string name)
        {
            Console.WriteLine("I'm tree "+ name +"\n");
        }
    }
}
