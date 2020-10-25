using System;
using System.Threading;
using System.Xml;
using System.Xml.Schema;

namespace XMLNode
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreateXML();
            XmlDocument doc = new XmlDocument();
            //doc.Load("123.xml");
            //doc.Load("Students.xml");
            doc.Load("book.xml");
            XmlElement root = doc.DocumentElement;
            ShowNode(root); // виводимо root і дочірні ноди
            //CreateRootAndChildren2();


            //Validate("schema.xsd", "Students.xml");
            Validate("schemaBook.xsd", "book.xml");
        }



        private static void ShowNode(XmlNode node)      // XmlNode -- самий базовий клас
        {
            Console.WriteLine("\nNodeType='{0}'  Name='{1}' InnerXml='{2}'  Value='{3}'",
                node.NodeType, node.Name,
                node.InnerXml, node.Value);
            if (node.Attributes != null)    // якщо є атрибути
            {
                Console.Write("attr: ");
                foreach (XmlAttribute attr in node.Attributes)
                {
                    Console.Write("{0}=\"{1}\"", attr.Name, attr.Value);
                }
            }

            if (node.HasChildNodes) // якщо є дочірні ноди
            {
                foreach (XmlNode child in node.ChildNodes)
                {
                    ShowNode(child);
                }
            }
            Console.WriteLine("");
        }

        private static void CreateXML()
        {
            Console.Clear();
            XmlDocument writer = new XmlDocument();
            XmlDeclaration declaration = writer.CreateXmlDeclaration("1.0", "ISO-8859-1", null);
            writer.AppendChild(declaration);
            XmlElement root = writer.CreateElement("PatientFile");
            writer.AppendChild(root);

            XmlElement ID = writer.CreateElement("ID");
            root.AppendChild(ID);

            XmlElement patientID = writer.CreateElement("PatientID");
            root.AppendChild(patientID);

            XmlElement patientName = writer.CreateElement("PatientName");
            root.AppendChild(patientName);

            XmlElement room = writer.CreateElement("Room");
            root.AppendChild(room);


            writer.Save("123.xml");
        }
        private static void Validate(string schema, string docName)
        {
            Thread.Sleep(1000);
            //Console.Clear();

            XmlDocument doc = new XmlDocument();
            doc.PreserveWhitespace = false;
            doc.Schemas.Add("", schema);
            doc.Load(docName);

            doc.Validate(HandlerValidate);
        }

        public static void HandlerValidate(Object sender, ValidationEventArgs e)
        {
            Console.WriteLine("HandlerValidate( sender='{0}')", sender);
            Console.WriteLine("\t Message:'{0}'", e.Message);
            Console.WriteLine("\tSeverity:'{0}'", e.Severity);
        }

      
    }
}
