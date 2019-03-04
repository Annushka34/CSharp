using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Lesson_Classes
{
    class Program
    {
       public enum Departmans { Economic = 10, Programmer, Managmant, Marketing };

        static void Main(string[] args)
        {
            //Doll d = new Doll();
            //Car c = new Car();
            //c.Show();
            //Console.WriteLine(c.GetType().Name);
            //Console.WriteLine(c.Price);
            //Console.WriteLine(c.GetPrice());

            //c.Price = 255;
            //Console.WriteLine(c.Price);


            //c.Doll = new Doll();
            //// Doll d = c.Doll;

            //c.Pswd = "1234567";
            ///// Console.WriteLine(c.Pswd); - get private!!!!!!!!!!!
            //c.Pswd = "123";
            //c.Pswd = "1234567";
            //c.Pswd = "147258";

            //MyEnumMenu menu1 = new MyEnumMenu();
            //MyEnum choice = menu1.MakeChoice();
            //Console.WriteLine(Enum.GetName(typeof(MyEnum), choice));

            //Console.WriteLine("------------------------------------");
            //menu1.ShowAllCases();


            ShowEnum();
        }
        static void ShowEnum()
        {
          //  var enumVals = Enum.GetNames(typeof(Departmans));
            //foreach (var item in enumVals)
            //{
            //    Console.WriteLine(item);
            //}

          //  Console.WriteLine( enumVals.GetValue(1) );
            //---10, 11, 12, 13
         //  var vals =  Enum.GetValues(typeof(Departmans));

            int dep =  (int)Enum.Parse(typeof(Departmans), "Programmer");
            Console.WriteLine(dep);
            Console.WriteLine(Enum.IsDefined(typeof(Departmans), 17));
            Console.WriteLine(Enum.IsDefined(typeof(Departmans), "Progr2ammer"));
        }
    }


    class Doll
    {
        public Doll()
        {
            Console.WriteLine("Doll created");
        }
      
    }
}
