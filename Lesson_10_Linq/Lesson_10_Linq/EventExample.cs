using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_Linq
{
    class EventExample
    {
        public delegate void Operat(int x, int y);
        public event Operat calc;
        
        public void Start()
        {
            if (calc != null)
            {
                calc(5, 10);
            }
        }
    }
}
