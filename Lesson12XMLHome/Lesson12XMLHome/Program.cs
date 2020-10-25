using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lesson12XMLHome
{
    class Program
    {
        static void Main(string[] args)
        {
            using (XmlTextWriter writer = new XmlTextWriter("Students.xml", System.Text.Encoding.Unicode))
            {
                writer.Formatting = Formatting.Indented;
                writer.WriteStartDocument();//заголовок
                writer.WriteStartElement("Students");//вузол 1
                writer.WriteStartElement("Student");//вузол 2
                writer.WriteAttributeString("Image", "photo1.jpeg");//атрибут
                writer.WriteElementString("Name", "Іван");//вкладений елемент з текстом
                writer.WriteElementString("Surname", "Петровський");
                writer.WriteElementString("EntireYear", "2017");
                writer.WriteElementString("Birthday", "2010-10-10");
                writer.WriteElementString("Occupation", "Programming");
                writer.WriteEndElement();//закриваючий до вузла 2
                writer.WriteEndElement();//закриваючий до вузла 1
                Console.WriteLine("Документ Students.xml створено");
            }
        }
    }
    }

