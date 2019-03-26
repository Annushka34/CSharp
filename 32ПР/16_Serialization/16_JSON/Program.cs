using _16_Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace _16_JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using DataContractJsonSerializer class - System.Runtime.Serialization;
            //Firm f = new Firm(9, "SuperCoolGuys");
            DataContractJsonSerializer dcjs = new DataContractJsonSerializer(typeof(Firm));
            //FileStream fs = new FileStream("jsonFirm_1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //dcjs.WriteObject(fs, f);
            //fs.Close();

            FileStream fs2 = new FileStream("jsonFirm_1.txt", FileMode.Open, FileAccess.ReadWrite);
            Firm newFirm = (Firm)dcjs.ReadObject(fs2);
            fs2.Close();
            Console.WriteLine(newFirm);


            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------");


            //Using JavaScriptSerializer class - System.WEb.Extention
            //---without private fields
            JavaScriptSerializer jss = new JavaScriptSerializer();
            Firm f2 = new Firm(9, "SuperCoolGuys_2");
            string str = jss.Serialize(f2);
            //  Console.WriteLine(str);

            Firm newF2 = (Firm)jss.Deserialize(str, typeof(Firm));
            Console.WriteLine(newF2);

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------");

            //  ---Nuget Package Manager --Add Newtonsoft.Json
            //-----without private fields
            Firm f3 = new Firm(7, "SuperCoolGuys_3");
            string str3 = JsonConvert.SerializeObject(f3);
            //   Console.WriteLine(str3);
           Firm fNew_3 =  (Firm)JsonConvert.DeserializeObject(str3, typeof(Firm));
            Console.WriteLine(fNew_3);


            //Random r = new Random();
            //for (int i = 0; i < 200; i++)
            //{
            //    Console.WriteLine(r.Next(0, 5));
            //    Thread.Sleep(10);
            //}

        }
    }
}
