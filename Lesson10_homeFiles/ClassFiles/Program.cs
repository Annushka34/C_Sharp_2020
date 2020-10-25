using System;
using System.IO;
using System.Text;

namespace ClassFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathToFile = @"./";
            string fileName = "test1.txt";
            string fullName = Path.Combine(pathToFile, fileName);

            Console.WriteLine(Path.GetDirectoryName(fullName));
            Console.WriteLine(Path.GetExtension(fullName));
            Console.WriteLine(Path.GetFullPath(fullName));

            //FileStream fs1 = new FileStream("fileNew.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //byte[] bytes = Encoding.UTF8.GetBytes("Hello world");
            //fs1.Write(bytes, 0, bytes.Length);
            //Console.WriteLine("Good. Write!");
            //fs1.Dispose();


            //using (FileStream fs = new FileStream(fullName, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            //{
            //    string text = Console.ReadLine();
            //    byte[] bytes = Encoding.UTF8.GetBytes(text);
            //    fs.Write(bytes, 0, bytes.Length);
            //    Console.WriteLine("Good. Write!");
            //}

            //using (FileStream fs = new FileStream("file.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            //{
            //    byte[] bytes = new byte[fs.Length];
            //    fs.Read(bytes, 0, bytes.Length);
            //    Console.WriteLine("Good. Read!");
            //    string str = Encoding.Default.GetString(bytes);
            //    Console.WriteLine(str);
            //}

            //StreamReader sr = new StreamReader(fullName);            
            //char[] buff = new char[255];
            //sr.Read(buff, 0, 255);
            //Console.WriteLine(buff);
            //sr.Close();

            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //using (FileStream fs = new FileStream("file.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            //{
            //    using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
            //    {
            //        string str = sr.ReadToEnd();
            //        Console.WriteLine(str);
            //    }
            //}

            string name = "D://MyImage.jpg";
            byte[] bytes;
            int len = 0;
            using (FileStream fs = new FileStream(name, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                using (BinaryReader br = new BinaryReader(fs, Encoding.Default))
                {
                    len = (int)fs.Length;
                    bytes = new byte[fs.Length];
                    br.Read(bytes, 0, bytes.Length);
                }
            }

            for (int i = len/2; i < len/2+50; i++)
            {
                bytes[i] = 100;
            }

            using (FileStream fs = new FileStream("D://MyImage1.jpg", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                using (BinaryWriter br = new BinaryWriter(fs, Encoding.Default))
                {
                    br.Write(bytes);
                }
            }



            //int num = Int32.Parse(Console.ReadLine());
            //for (int i = 0; i < num; i++)
            //{            
            //using (FileStream fs = new FileStream("D://copy+"+i+".bmp", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            //{
            //    using (BinaryWriter br = new BinaryWriter(fs))
            //    {
            //            br.Write(bytes, 0, bytes.Length);
            //            string str = "create by Anna " + i.ToString();
            //            byte[] b = Encoding.UTF8.GetBytes(str);
            //            br.Write(b, 0, b.Length);
            //        }
            //}
            //}

            //FileInfo fi = new FileInfo("D://test.txt");
            //fi.Create();

        }
    }
}
