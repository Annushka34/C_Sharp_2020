using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ownattribute
{
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User();
            Console.WriteLine(typeof(User).GetCustomAttributes(false)[0].ToString());
            MemberInfo[] mi = typeof(User).GetMembers();
            foreach (var item in mi)
            {
                foreach (var i in item.GetCustomAttributes(true))
                {
                    Console.WriteLine(i.ToString());
                }
            }
        }
    }
    //[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    class isReadyAttribute: Attribute
    {
        bool _isReady;
        public isReadyAttribute()
        {

        }
        public isReadyAttribute(bool isReady)
        {
            _isReady = isReady;
        }
        public override string ToString()
        {
            return _isReady.ToString();
        }
    }

    [isReady(true)]
    class User
    {
       
        public int Name { get; set; }
        [isReady(false)]
        [Required]
        public string Work { get; set; }
    }
}
