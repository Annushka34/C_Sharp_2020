namespace Lesson11_homeSerialization
{
    using System;
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Runtime.Serialization.Formatters.Soap;
    using System.Xml.Serialization;

    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Group group = new Group();
            group.Create();
            group.ShowGroup();
            Console.WriteLine("--------------------------");

            Student st1 = new Student("Dima", 30, "Dmitruk");
            Student st2 = new Student("Ivan", 20, "Petrov");
            Student st3 = new Student("Semen", 17, "Dmitruk");
            st1.Show();
            st2.Show();
            st3.Show();

            // // BinaryFormatter
            // BinaryFormatter binaryFormatter = new BinaryFormatter();
            // FileStream fs = new FileStream(@"D:/students.bin", FileMode.OpenOrCreate);
            ////  binaryFormatter.Serialize(fs, group);
            // Group g = (Group)binaryFormatter.Deserialize(fs);
            // fs.Close();
            // Console.WriteLine("group was binary deserialized");
            // g.ShowGroup();

            //// SoapFormatter
            //SoapFormatter sFormatter = new SoapFormatter();
            //FileStream fs1 = new FileStream(@"D:/students1.txt", FileMode.OpenOrCreate);
            ////sFormatter.Serialize(fs1, st1);
            ////sFormatter.Serialize(fs1, st2);
            ////sFormatter.Serialize(fs1, st3);
            //Student st4 = null;
            //Student st5 = null;
            //Student st6 = null;
            //Student st7 = null;
            //Student st8 = null;
            //try
            //{
            //    st4 = (Student)sFormatter.Deserialize(fs1);
            //    st5 = (Student)sFormatter.Deserialize(fs1);
            //    st6 = (Student)sFormatter.Deserialize(fs1);
            //   // st7 = (Student)sFormatter.Deserialize(fs1);
            //   // st8 = (Student)sFormatter.Deserialize(fs1);
            //}
            //catch
            //{

            //}

            //fs1.Close();
            //Console.WriteLine("group was soap deserialized");
            //st4.Show();
            //st5.Show();
            //st6.Show();
            // st7.Show();

            XmlSerializer xmls = new XmlSerializer(typeof(Student));
            FileStream fs3 = new FileStream(@"D:/xmlStuden.txt", FileMode.OpenOrCreate);
           // xmls.Serialize(fs3, group);
            xmls.Serialize(fs3, st1);
            xmls.Serialize(fs3, st2);
            xmls.Serialize(fs3, st3);

            //Group newGroup = (Group)xmls.Deserialize(fs3);
            Student st4 = (Student)xmls.Deserialize(fs3);
            Student st5 = (Student)xmls.Deserialize(fs3);
            Student st6 = (Student)xmls.Deserialize(fs3);
            fs3.Close();
            //newGroup.ShowGroup();
            st4.Show();
            st5.Show();
            st6.Show();

            //XmlSerializer xmls2 = new XmlSerializer(typeof(List<Product>));
            //FileStream fs3 = new FileStream(@"D:/xmlProduct1.xml", FileMode.Truncate);
            ////xmls2.Serialize(fs3, new Product("bread", "descr1", 12, 2));
            //List<Product> p = new List<Product>
            //{
            //    new Product("milk", "descr4", 16, 3),
            //    new Product("bread", "descr1", 12, 2)
            //};
            ////Product p = new Product();
            ////p.Create("milk", "descr4", 16, 3);
            //xmls2.Serialize(fs3, p);
            //foreach (var prod in p)
            //    prod.Show();

            ////
            //////Product p2 = (Product)xmls2.Deserialize(fs3);
            ////p1.Show();
            //fs3.Close();
            //FileStream fs4 = new FileStream(@"D:/xmlProduct1.xml", FileMode.Open);
            //List<Product> p1 = (List<Product>)xmls2.Deserialize(fs4);
            //fs4.Close();
            //foreach (var prod in p1)
            //    prod.Show();

            //SoapFormatter sf2 = new SoapFormatter();
            //FileStream fs4 = new FileStream(@"D:/soapProduct1.soap", FileMode.OpenOrCreate);
            ////sf2.Serialize(fs4, p);
            //Product p4 = (Product)sf2.Deserialize(fs4);
            //p4.Show();
            //fs4.Close();
        }
    }
}
