using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace AssemblyLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Console.WriteLine("full name : " + assembly.FullName);
            //Console.WriteLine("Location : " + assembly.Location);
            //Console.WriteLine("EntryPoint : " + assembly.EntryPoint);



            string path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            ////Console.WriteLine("path: " + path);

            //DirectoryInfo di = new DirectoryInfo(path).Parent.Parent;
            //Console.WriteLine(di.FullName);

            //Assembly newAss =  Assembly.LoadFrom(@"D:\STEP\c#\2020\C_Sharp_2020\Assamblies\AssemblyLoad\ClassLibrary1\bin\Debug\ClassLibrary1.dll");
            //Type[] types =  newAss.GetTypes();
            //foreach (var t in types)
            //{
            //    if (t.IsClass)
            //    {
            //        Console.WriteLine(t.Name);
            //        var flower = Activator.CreateInstance(t);
            //        MethodInfo method =  t.GetMethod("ShowTree");                    
            //        if(method != null)
            //        {
            //            method.Invoke(flower, new string[] {"Bereza"});
            //        }

            //    }
            //}

            List<Type> list = new List<Type>();
            foreach (string s in Directory.GetFiles(path, "*.dll"))
            {
                Assembly a = Assembly.LoadFrom(s);
                foreach (Type t in a.GetExportedTypes())
                {
                    if (!t.IsClass | !typeof(MyIntarface).IsAssignableFrom(t))
                    {
                        continue;
                    }
                    list.Add(t);
                }
            }

            //// вызов метода интерфейса для всех                 
            //// найденных типов                
            foreach (Type t in list)
            {
                Console.WriteLine((Activator.CreateInstance(t) as MyIntarface).Hello());
            }

            //--------------------------------------------------------

            //--2
            //foreach (Type t in types1)
            //{
            //    MyIntarface m = (MyIntarface)(Activator.CreateInstance(t));
            //    m.Hello();
            //}

            //IPerson 
            Type type1 = Type.GetType("Student");
            //Type type2 = Type.GetType("Employee");

            IPerson h1 = (Activator.CreateInstance(type1)) as Student;
            //IPerson h2 = (Employee)(Activator.CreateInstance(type2));
            h1.Show();
            //h2.Show();

            //    ////Отобразить имена методов в тиnе. 


            //    //-------------------------------------------------
            Type type3 = Type.GetType("Student");
            Console.WriteLine("***** Methods *****");
            MethodInfo[] mi = type3.GetMethods();


            object obj = (Activator.CreateInstance(type3));


            foreach (MethodInfo m in mi)
            {
                Console.WriteLine("-> {0}", m.Name);
                try
                {
                    m.Invoke(obj, new string[] { "Vasja" });
                }
                catch { }
            }
            //Console.WriteLine("---------------------------------\n\n");
            //MethodInfo mi1 = type3.GetMethod("Show");
            //mi1.Invoke(obj, null);
        }
        }
}
public interface IPerson
{
    void Show();
}
public class Student : IPerson
{
    string name = "Petro";
    public void Show()
    {
        Console.WriteLine("Petro live on Miru 24");
    }
    public void SetName(string name)
    {
        Console.WriteLine("set name: "+name);
    }

}
public class Employee : IPerson
{
    string name = "Vasja";
    public void Show()
    {
        Console.WriteLine("Vasja live on Soborna");
    }
}
class MyClass
{

}
