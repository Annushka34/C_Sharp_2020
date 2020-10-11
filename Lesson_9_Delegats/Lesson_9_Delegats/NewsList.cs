using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9_Delegats
{
    public delegate void SendNews(string name);
   

    class NewsSender
    {
        public SendNews news;
        public void Send(string newText)
        {
            news(newText);
        }
    }

    class Subscriber
    {
        public string name;
        public Subscriber(string name)
        {
            this.name = name;
        }
        public void GetNew(string news)
        {
            Console.WriteLine(name + "   got   "+ news);
        }
    }
}
