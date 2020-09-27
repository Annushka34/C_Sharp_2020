using System;

namespace Lesson_5_GC_try_catch
{
    class MyEx : ApplicationException
    {
      //  private string msg = "";
        public MyEx(): base("developer: Pylaieva")
        {
           // msg = "MyExeption";
        }
        public MyEx(string msg):base(msg)
        {
           // this.msg = msg;
        }
       // public override string Message => msg;
    }


    //Exception tab tab
    [Serializable]
    public class MyException : Exception
    {
        public MyException() { }
        public MyException(string message) : base(message) { }
        public MyException(string message, Exception inner) : base(message, inner) { }
        protected MyException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
