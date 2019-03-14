using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Exeptions
{
    class MyEx : Exception
    {
        string owner = "Pilaeva Anna";
        string logFilePath = @"D:/LOGS/log.txt";
      //  string msg;
        public MyEx(string msg): base(msg)
        {
           // this.msg = msg;
        }
        public override string HelpLink { get => @"https://google.com"; set => base.HelpLink = value; }
        public override string Message
        {
            get
            {
                Console.WriteLine( base.Source);
                Console.WriteLine(base.Message);
                Console.WriteLine(owner);
                return base.Message;
            }           
        }
    }


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
