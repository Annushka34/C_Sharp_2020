using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.IO;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using DataContractJsonSerializer class - System.Runtime.Serialization;
            //DataContractJsonSerializer dcjs = new DataContractJsonSerializer(typeof(List<Person>));

            //List<Person> p1 = new List<Person>
            //{
            //    new Person("vasja","petrov", 30),
            //    new Person("ivan","sidorov",20)
            //};
            //using (FileStream fs = new FileStream(@"D:/json1.txt", FileMode.OpenOrCreate))
            //{
            //    dcjs.WriteObject(fs, p1);
            //}

            //List<Person> p2 = null;
            //using (FileStream fs = new FileStream(@"D:/json1.txt", FileMode.Open))
            //{
            //    p2 = dcjs.ReadObject(fs) as List<Person>;
            //}
            //foreach (var p in p2)
            //{                
            //    Console.WriteLine(p);
            //}


            ////Using JavaScriptSerializer class - System.WEb.Extention
            List<Product> prod = new List<Product>
            {
                new Product { 
                    Price=100, 
                    ProductName="Phone", 
                    Persons = new List<Person>
                    {
                        new Person ("AAAA", "Ivanox", 13) ,
                        new Person ("BBBB", "Ivanox", 13)
                    }
                },
                new Product{Price=20, ProductName="Mouse", Persons = new List<Person>()},
                new Product{Price=2500, ProductName="TV", Persons = new List<Person>()}
            };
            //Console.WriteLine("------------------------------------");
            //JavaScriptSerializer jss = new JavaScriptSerializer();
            //string json = jss.Serialize(prod);
            //Console.WriteLine(json);

            //List<Product> p3 = jss.Deserialize<List<Product>>(json);
            //foreach (var p in p3)
            //{
            //    Console.WriteLine(p);
            //}

            ////Using JSON.NET library
            string json2 = JsonConvert.SerializeObject(prod);
            Console.WriteLine("------------------------------------");
            Console.WriteLine(json2);
            List<Product> p4 = JsonConvert.DeserializeObject<List<Product>>(json2);
            foreach (var p in p4)
            {
                Console.WriteLine(p);
            }
        }
    }

    [DataContract]
    class Person
    {
        [DataMember]
        public string Name { get; set; }
        //  [JsonIgnore]
        [DataMember]
        public string Surname { get; set; }
        [DataMember]
        public int Age { get; set; }
        public Person(string Name, string Surname, int age)
        {
            Age = age;
            this.Name = Name;
            this.Surname = Surname;
        }
        public override string ToString()
        {
            return $"{Name} {Surname} {Age}";
        }
    }

    class Product
    {
        [JsonIgnore]
        public string ProductName { get; set; }
        public int Price { get; set; }
        public Product(string ProductName,  int Price)
        {
            this.ProductName = ProductName;
            this.Price = Price;
        }

        public List<Person> Persons { get; set; } 
        public Product()
        {

        }
        public override string ToString()
        {
            this.Persons.ForEach( x=> Console.WriteLine(x.Name));
            return $"{Price} {ProductName} ";
        }
    }
}
