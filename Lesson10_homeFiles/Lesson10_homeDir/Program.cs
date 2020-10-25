using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10_homeDir
{
    class Program
    {
        static void Main(string[] args)
        {
            ////DirectoryInfo
            ////FileInfo
            ////Directory
            ////File
            //  DriveInfo[] drives =  DriveInfo.GetDrives();
            //  drives.ToList().ForEach(x => Console.WriteLine(x));
            //  DriveInfo drive = new DriveInfo("D://");
            //  //drive.
            //  DirectoryInfo dir = new DirectoryInfo(drives[1].Name);
            //  Console.WriteLine(dir.CreationTime);
            //  Console.WriteLine(dir.Name);
            ////  Console.WriteLine(dir.Parent.Name);
            //  Console.WriteLine(dir.FullName);

            //  DirectoryInfo[] dirs = dir.GetDirectories();
            //  dirs.ToList().ForEach(x => Console.WriteLine(x));

            //  Console.WriteLine("FILES:");
            //  FileInfo[] files = dir.GetFiles();
            //  files.ToList().ForEach(x => Console.WriteLine(x));



            //DirectoryInfo newDir = new DirectoryInfo(@"D:\NewDirTest");
            //if (!newDir.Exists)
            //{
            //    newDir.Create();
            //}

            //DirectoryInfo newDir2 = newDir.CreateSubdirectory("myFolder");
            //Console.WriteLine(newDir2.FullName);

            //string path = newDir2.FullName + "\\test.png";
            //FileInfo file = new FileInfo(path);
            //if (!file.Exists)
            //    file.Create();
            //Console.WriteLine(file.FullName);


            // File.Create("newFile.txt");
            //File.WriteAllText("newNewFile.txt", "Hello world\n");
            //File.AppendAllText("newNewFile.txt", "Hello world");            

            //string pathFrom = "D:\\resorce.png";
            //byte[] bytes;
            //using (FileStream fs = new FileStream(pathFrom, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            //{
            //    Console.WriteLine("open " + pathFrom);

            //    bytes = new byte[(int)fs.Length];
            //    fs.Read(bytes, 0, bytes.Length);
            //    Console.WriteLine("read");
            //}

            //using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            //{
            //    Console.WriteLine("open "+path);
            //    fs.Write(bytes, 0, bytes.Length);
            //    Console.WriteLine("write");
            //}

            MoveDelRename mvd = new MoveDelRename();
            mvd.Run();
        }
    }
}
