using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace LinqXML
{
    class Program
    {
        static void Main(string[] args)
        {
            //BuildXmlDocWithDOM();
            //BuildXmlDocWithLINQToXml();
            //DeleteNodeFromDoc();
            //CreateFullXDocurnent();
            //CreateFullXDocurnentSimle();
            //MakeXElementFromArray();
            //Objects o = new Objects();
            //o.Run();
            //ParseAndLoadExistingXrnl();
            //InsertNewElement("Renault", "Red", "Logan");
            //InsertNewElement("BMW", "Green", "X6");

            //ParseAndLoadExistingXrnl();
            LookUpColorsForMake("Renault");

        }
        //XMLDOC
        private static void BuildXmlDocWithDOM()
        {
            // Соsдать новый дохумент ХМL в nамяти. 
            XmlDocument doc = new XmlDocument();
            // Заnолнить дохумент корневыи элементом no инени<Parking>. 
            XmlElement parking = doc.CreateElement("Parking");
            // Соsдать nодэлемент no инени<Car> с атрибутом ID.
            XmlElement car = doc.CreateElement("Car");
            car.SetAttribute("ID", "1000");
            //Построить данные внутри элемента<Car>. 
            XmlElement name = doc.CreateElement("PetName");
            name.InnerText = "JirnЬo";
            XmlElement color = doc.CreateElement("Color");
            color.InnerText = "Red";
            XmlElement make = doc.CreateElement("Make");
            make.InnerText = "Ford";
            // Добавить к элементу<Car> элементы<PetNaшe>, < Color > и<Маkе>.
            car.AppendChild(name);
            car.AppendChild(color);
            car.AppendChild(make);
            //Добавить к элементу<Inventory> элемент<Car>. 
            parking.AppendChild(car);
            //Вставитъ завершенный ХМL в обоъехт XIDlDocuшent и сохранить в файпе. 
            doc.AppendChild(parking);
            doc.Save("Parking.xml");
            Console.WriteLine("Документ parking.xml створено");
        }

        private static void BuildXmlDocWithLINQToXml()
        {
            //Создать документ ХМL в более "функциональной" манере.
            XElement doc = new XElement("Parking",
                new XElement("Car",
                    new XAttribute("ID", "1000"),
                    new XElement("PetName", "JimЬo", new XAttribute("ID","200")),
                    new XElement("Color", "Red"),
                    new XElement("Make", "Ford")));
            // Сохранить документ файле.
            doc.Save("ParkingWithLINQ.xml");
            
            Console.WriteLine("Документ parkingLinq.xml створено");
        }
        private static void DeleteNodeFromDoc()
        {
            XElement doc = new XElement("Parking",
                new XElement("Car", new XAttribute("ID", "1000"),
                    new XElement("PetName", "Jimbo"),
                    new XElement("Color", "Red"),
                    new XElement("Make", "Ford"))
            );
            Console.WriteLine(doc);
            Console.WriteLine("----after removing----");
            //Удалить элемент PetNaшe из дерева.
            doc.Descendants("PetName").Remove();            
           
            //Descendants<T> Возвращает отфильтрованную коллекцию элементов, которая содержит 
            //элементы - потомки каждого элемента и документа в исходной коллекции
            //puЬlic IEnumeraЬle<XElement> Descendants(XName nаmе) 
            Console.WriteLine(doc);
        }
        static void CreateFullXDocurnent()
        {
            XDocument parkingDoc = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("Current Parking of cars! "),
                new XProcessingInstruction("xml-stylesheet", "href= 'MyStyles.css' title=' Compact' type='text/css'"),
                new XElement("Parking",
                    new XElement("Car", new XAttribute("ID", "1"),
                        new XElement("Color", "Green"),
                        new XElement("Make", "BMW"),
                        new XElement("PetName", "Stan")),
                    new XElement("Car", new XAttribute("ID", "2"),
                        new XElement("Color", "Pink"),
                        new XElement("Make", "Yugo"),
                        new XElement("PetName", "Melvin"))
                    ));
            // Сохранить на диске.
            parkingDoc.Save("SimpleParking.xml");
        }
        static void CreateFullXDocurnentSimle()
        {
            XElement parkingDoc =
                new XElement("Parking",
                new XComment("Current Parking of cars! "),
                    new XElement("Car", new XAttribute("ID", "1"),
                        new XElement("Color", "Green"),
                        new XElement("Make", "BMW"),
                        new XElement("PetName", "Stan")),
                    new XElement("Car", new XAttribute("ID", "2"),
                        new XElement("Color", "Pink"),
                        new XElement("Make", "Yugo"),
                        new XElement("PetName", "Melvin"))
                    );
            // Сохранить на диске.
            parkingDoc.Save("XMLSimpleParking.xml");
        }
        static void MakeXElementFromArray()
        {
            //Создать анонимный массив анонимных тиnов.
            var people = new[] {
                new { FirstName = "Mandy", Age = 32 },
                new { FirstName = "Andrew", Age = 40 },
                new { FirstName = "Dave", Age = 41 },
                new { FirstName = "Sara", Age = 31 } };
            XElement peopleDoc1 = new XElement("Реорlе");

            foreach (var c in people)
            {
                peopleDoc1.Add(
                  new XElement("Person",
                      new XAttribute("Age", c.Age),
                      new XElement("FirstName", c.FirstName)));
            }
                Console.WriteLine(peopleDoc1);
                Console.WriteLine("--------------ВАРІАНТ 2-----------------------");


                XElement peopleDoc = new XElement("Реорlе",
                    from p in people
                    select
                        new XElement("Person",
                            new XAttribute("Age", p.Age),
                            new XElement("FirstName", p.FirstName)));
                Console.WriteLine(peopleDoc);
            Console.WriteLine("--------------ВАРІАНТ 3-----------------------");

            var arrayDataAsXElements = from p in people
                                       select 
                                       new XElement("Person", new XAttribute("Age", p.Age),
                                       new XElement("FirstName", p.FirstName));
            XElement peopleDoc3 = new XElement("People", arrayDataAsXElements);
            Console.WriteLine(peopleDoc);
            //from переменная in набор_объектов
            //select переменная;
        }
        static void ParseAndLoadExistingXrnl()
        {
            //Построить объект XElement из строки. 
            string myElement = 
                @"<Car ID ='3'> 
                    <Color>Yellow</Color> 
                        <Make>Yugo</Make> 
                  </Car>";
            XElement newElernent = XElement.Parse(myElement);
            Console.WriteLine(myElement);
            Console.WriteLine();
            //Загрузить файл Simpleinventory.xml.
            XDocument myDoc = XDocument.Load("XMLSimpleParking.xml");
            Console.WriteLine(myDoc);
        }
        public static void InsertNewElement(string make, string color, string petName)
        {
            //Загрузить текущий документ.
            XDocument inventoryDoc = XDocument.Load("XMLSimpleParking.xml");
            //Сгенерировать случайное число для идентификатора.
            Random r = new Random();
            //Создать новый объект XElement на основе входных nараметров.
            XElement newElement = new XElement("Car", new XAttribute("ID", r.Next(50000)),
                new XElement("Color", color), 
                new XElement("Make", make), 
                new XElement("PetName", petName));
            //Добавить к объекту XDocument в nамяти.
            inventoryDoc.Descendants("Parking").First().Add(newElement);
            //Сохранить изменения на диске.
            inventoryDoc.Save("XMLSimpleParking.xml"); 
}
        public static void LookUpColorsForMake(string make)
        { //Загрузить текущий документ.
            XDocument parkingDoc = XDocument.Load("XMLSimpleParking.xml");
            //Найти цвета для заданного изготовителя.
            var makeinfo = from car in parkingDoc.Descendants("Car")
                           where (string)car.Element("Make") == make
                           select car.Element("PetName").Value;
            //Построить строку, nредставляющую каждый цвет. 
            string data = string.Empty;
            foreach (var item in makeinfo) 
            {
                data += string.Format("- {0}\n", item);
            }
            Console.WriteLine(data);
            //--------------Простий спосіб foreach------------------------------------
            string data1 = "";
            IEnumerable<XElement> cars = parkingDoc.Descendants("Car");
            foreach(var item in cars)
            {
                if((string)item.Element("Make")==make)
                {
                    data1 += item.Element("Color").Value;
                    data1 += "\n";                    
                }
            }
            Console.WriteLine(data1);
        }
        }
    
}


