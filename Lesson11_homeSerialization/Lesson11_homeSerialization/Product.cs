using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lesson11_homeSerialization
{
    [Serializable]
    public class Product
    {
        public static int counter=0;
        [XmlAttribute]
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        [XmlIgnore]
        public int id;
        [XmlIgnore]
        private string shop = "backerry";
        public string Shop
        {
            set => shop=value;
            get => shop;
        }
        public Product()
        {
            counter++;
        }
       
        public Product(string name, string descr, int price, int id)
        {
            this.ProductName = name;
            this.Description = descr;
            this.Price = price;
            this.id = id;
        }
        
        public void Create(string name, string descr, int price, int id)
        {
            this.ProductName = name;
            this.Description = descr;
            this.Price = price;
            this.id = id;
        }

        [OnSerializing]
        public void DoSmth(StreamingContext context)
        {
            Console.WriteLine("serializing....");
            this.ProductName = counter.ToString() + "." + ProductName;
            this.Description = counter.ToString() + "." + Description;
            Price = 100;
        }

        [OnDeserialized]
        public void DoSmth1(StreamingContext context)
        {
            Console.WriteLine("...end....");
            this.ProductName = ProductName.Split('.')[1];
            this.Description = Description.Split('.')[1];
        }

        public void Show()
        {
            Console.WriteLine($"{ProductName} {Description} {Price} id = {id} shop = {shop}");
        }
    }
}

