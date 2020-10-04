using System;
using System.Collections;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_Generic
{
    static class CollectionSpecialized
    {
        //   ключ-значення
        //    Hashtable - дерево
        //    SortedList - дерево выдсортоване
        //    ListDictionary - список
        //   типызовані
        //    Dictionary


        public static void Hashtable()
        {
            //   бінірне дерево
            Hashtable hashtable = new Hashtable();
            hashtable.Add("Ivanov", 12000);
            hashtable["Petrov"] = 10500;

            //   бінарне дерево з відсортованими ключами
            SortedList sortedList = new SortedList();
            sortedList.Add("Ivanov", 12000);
            sortedList["Petrov"] = 10500;

            //   повнозвязний список
            ListDictionary listDictionary = new ListDictionary();
            listDictionary.Add("Ivanov", 12000);
            listDictionary["Petrov"] = 10500;

            //  адаптовується під розмір коллекції - до 10 працює як ListDictionary, більше 10-ти елементів як Hashtable
            HybridDictionary hybridDictionary = new HybridDictionary();
            hybridDictionary.Add("Ivanov", 12000);
            hybridDictionary["Petrov"] = 10500;

            // можна однакові ключі
            NameValueCollection nameValueCollection = new NameValueCollection();
            nameValueCollection.Add("Ivanov", "12000");
            nameValueCollection["Petrov"] = "10500";
            nameValueCollection["Petrov"] = "13800";//перезаписує
            nameValueCollection.Add("Petrov", "7500");

            string[] values = nameValueCollection.GetValues("Petrov");
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------------------------");

            NameValueCollection settings = ConfigurationManager.AppSettings;
            foreach (string key in settings)
            {
                Console.WriteLine(key);
                Console.WriteLine(settings[key]);
            }

            var pswd = Console.ReadLine();
            if(settings["password"] == pswd)
            {
                Console.WriteLine("Good");
            }


            // BitArray bitArray = new BitArray(new byte[]{ 1, 0 });
            Console.WriteLine("BitArray 1");
            BitArray bitArray = new BitArray(3);
            bitArray.Set(0, true);
            bitArray.Set(2, true);
            bitArray.Length = 4;
            foreach (var item in bitArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("BitArray 2");
            BitArray bitArray2 = new BitArray(4);
            bitArray2.Set(0, false);
            bitArray2.Set(2, true);
            foreach (var item in bitArray2)
            {
                Console.WriteLine(item);
            }

            var newBitArr =  bitArray.And(bitArray2);

            Console.WriteLine("BitArray And");
            foreach (var item in newBitArr)
            {
                Console.WriteLine(item);
            }


            BitVector32 bitVector32 = new BitVector32(11);
            int mask = BitVector32.CreateMask(10);

            var val = bitVector32[mask];
            Console.WriteLine(val);
        }
    }
}
