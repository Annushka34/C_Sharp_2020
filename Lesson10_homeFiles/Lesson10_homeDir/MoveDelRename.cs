using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10_homeDir
{
    class MoveDelRename
    {
        public void Run()
        {
            //DriveInfo []drivers = DriveInfo.GetDrives();
            //foreach (var d in drivers)
            //{
            //    if(d.IsReady)
            //    Console.WriteLine(d.Name+"  size"+ d.TotalSize/1024/1024/1024+" Gb");// bytes/ kB/ mB/ Gb
            //}
            //DirectoryInfo di = new DirectoryInfo(drivers[1].Name);

            //foreach (DirectoryInfo d in di.GetDirectories())
            //{            
            //    Console.WriteLine(d.Name);
            //}
            //DirectoryInfo newDir = di.GetDirectories()[1].CreateSubdirectory("newDir");
            //string path = newDir.Name;
            //  DirectoryInfo newDir2 = newDir.CreateSubdirectory("included");

            //FileInfo f = newDir2.GetFiles()[0];
            //Console.WriteLine(f.FullName);


            //f.MoveTo("D://test111222211111111.txt");
            // f.CopyTo("D://2222222222222.txt");
            //  f.Delete();
            //newDir2.MoveTo("D://newDir1");

            //newDir2.MoveTo(di.GetDirectories()[1].FullName);
            //DirectoryInfo dir = new DirectoryInfo("D://newDir1");
            //Console.WriteLine(dir.FullName);

            DirectoryInfo dir5 = new DirectoryInfo(@"D:\6\newDir");
            //dir5.Delete(true);

            dir5.MoveTo(@"D:\6\newDir2");

            //using (StreamWriter sw = new StreamWriter(fnew.FullName, false))
            //{
            //    Console.WriteLine(fnew.FullName);
            //    sw.Write("ann");
            //}
        }
    }
}
