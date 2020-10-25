using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10_homeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\ШАГ\с#\examples\Lesson10_homeFiles\";
            //string fileName = @"load.bmp";
            string fileName = @"123.png";

            //string fileName = @"myFile1.txt";
            string fullPath = Path.Combine(filePath, fileName);
            Console.WriteLine(fullPath);
            Console.WriteLine(Path.GetFileName(fullPath));
            Console.WriteLine(Path.GetExtension(fullPath));
            //WriteToFile(fullPath);
            //ReadFromFile(fullPath);
            ReadAndWriteFromFile(fullPath);
            //WriteStreamWriter();
            //ReadStreamReader();

            //StreamWriter sw = new StreamWriter(@"D:\ШАГ\с#\examples\Lesson10_homeFiles\test4.txt");

            //sw.WriteLine("hello");
            //sw.WriteLine(5);
            //sw.Close();

            //StreamReader sr = new StreamReader(@"D:\ШАГ\с#\examples\Lesson10_homeFiles\test4.txt");
            //Console.WriteLine( sr.ReadLine());
            //Console.WriteLine(sr.ReadLine());
            //sr.Close();
            //BinaryWrite();
            //BinaryRead();
        }
        static void WriteToFile(string fullPath)
        {
            //string str = ")))I write to file this phrase))";
            string str = "111";
            using (FileStream fs = 
                new FileStream(fullPath,FileMode.Open, FileAccess.Write))
            {
                byte[] bytes = Encoding.UTF8.GetBytes(str);
                fs.Seek(5, SeekOrigin.Begin);
                fs.Write(bytes, 0, bytes.Length);
                Console.WriteLine("writed!!!");
            }
        }
        static void ReadFromFile(string fullPath)
        {
            using (FileStream fs =
                new FileStream(fullPath, FileMode.Open, FileAccess.Read))
            {
                byte[] bytes = new byte[(int)fs.Length];
                fs.Read(bytes, 0, bytes.Length);
                Console.WriteLine("read!!!");
                Console.WriteLine(Encoding.Default.GetString(bytes));
                Console.WriteLine(Path.GetFullPath(fullPath));
            }
        }
        static void ReadAndWriteFromFile(string fullPath)
        {
            byte[] bytes;
            using (FileStream fs =
                new FileStream(fullPath, FileMode.Open, FileAccess.ReadWrite))
            {


                bytes = new byte[(int)fs.Length];
                fs.Read(bytes, 0, bytes.Length);
                Console.WriteLine("read!!!");
              
            }
            //for (int i = 0; i < 3; i++)
            //{
            //    string path = @"D:\ШАГ\с#\examples\Lesson10_homeFiles\test"+
            //        i.ToString()+".png";
            //using (FileStream fs =
            //    new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            //{
            //    fs.Write(bytes, 0, bytes.Length);
            //    Console.WriteLine("writed!!!");
            //}
            //}
        }

        static void WriteStreamWriter()
        {
            string fullPath= @"D:\ШАГ\с#\examples\Lesson10_homeFiles\test2.txt";
            using (FileStream fs = new FileStream(fullPath, FileMode.OpenOrCreate))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                {
                    sw.WriteLine(Console.ReadLine());
                    Console.WriteLine("writen!!!");
                }
            }
        }
        static void ReadStreamReader()
        {
            string fullPath = @"D:\ШАГ\с#\examples\Lesson10_homeFiles\test2.txt";
            using (FileStream fs = new FileStream(fullPath, FileMode.OpenOrCreate))
            {
                using (StreamReader sr = new StreamReader(fs, Encoding.Unicode))
                {
                    Console.WriteLine(sr.ReadToEnd());
                    Console.WriteLine("readed!!!");
                }
            }
        }

        static void BinaryWrite()
        {
            string fullPath = @"D:\ШАГ\с#\examples\Lesson10_homeFiles\test5.dat";
            using (FileStream fs = new FileStream(fullPath, FileMode.OpenOrCreate))
            {
                using (BinaryWriter bw = new BinaryWriter(fs, Encoding.Unicode))
                {
                    bw.Write(Console.ReadLine());
                    bw.Write(111);
                    bw.Write("привіт");
                    Console.WriteLine("writen!!!");
                }
            }
        }
        static void BinaryRead()
        {
            string fullPath = @"D:\ШАГ\с#\examples\Lesson10_homeFiles\test5.dat";
            using (FileStream fs = new FileStream(fullPath, FileMode.OpenOrCreate))
            {
                using (BinaryReader bw = new BinaryReader(fs, Encoding.Unicode))
                {
                    Console.WriteLine(bw.ReadString());
                    Console.WriteLine(bw.ReadInt32());
                    Console.WriteLine(bw.ReadString());
                    Console.WriteLine("readed!!!");
                }
            }
        }
    }
}
