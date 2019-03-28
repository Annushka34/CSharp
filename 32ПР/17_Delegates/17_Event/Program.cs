using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _17_Event
{
    class Program
    {
       
        static void Main(string[] args)
        {

            Button b = new Button();
            //  b.ButtonClickNo += B_ButtonClickNo;
            Console.WriteLine("1-yes, 2-No");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
               b.Yes();
            else b.No();
        }

        private static string B_ButtonClickNo()
        {
            throw new NotImplementedException();
        }
    }
}
