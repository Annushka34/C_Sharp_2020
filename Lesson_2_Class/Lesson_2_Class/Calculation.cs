using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_2_Class
{
    partial class Calculation
    {
        private int _x; //   поля
        private int _y;
        private string _name;
        private int _position;

        //   автовластивість
        public char Operation { get; private set; } = '+'; // prop tab tab

        public Calculation()
        {
            Operation = '*';
        }

        public void SetX(int x)  //   метод
        {
            if (x <= 0)
            {
                _x = 0;
            }
            else
            {
                _x = x;
            }
        }

        public int GetX()
        {
            return _x;
        }


        public int SetY  // property   властивість
        {
            set
            {
                _y = value;
            }
        }

        public int GetY  // property   властивість
        {
            get
            {
                return _y;
            }
        }

        public int Y
        {
            set
            {
                _y = value;
            }

            get
            {
                return _y;
            }
        }


        public string Name
        {
            set
            {
                _name = value;
            }
        }

        public int Position
        {
            set => _position = value;
            private get => _position;
        }


    }
}
