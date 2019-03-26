using _16_Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Xml.Serialization;

namespace _17_SoapFormatter
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Person> p = new List<Person>()
            //{
            //    new Person("Semen", 30),
            //    new Person("Oleg", 22),
            //    new Person("Vasilij", 18),
            //    new Person("Inna", 45)
            //};

            //-----Add reference - search in Assembly "Soap"---(System.Runtime.Serialization.Formatters.Soap)
            SoapFormatter sFormatter = new SoapFormatter();
            //     FileStream fs = new FileStream("firmDataSoap.txt", FileMode.OpenOrCreate, FileAccess.Write);
            //foreach (var item in p)
            //{
            //   sFormatter.Serialize(fs, item);
            //}

            FileStream fs = new FileStream("firmDataSoap.txt", FileMode.Open, FileAccess.Read);
            List<Person> pNew = new List<Person>();
            pNew.Add((Person)sFormatter.Deserialize(fs));
            pNew.Add((Person)sFormatter.Deserialize(fs));
            pNew.Add((Person)sFormatter.Deserialize(fs));
            pNew.Add((Person)sFormatter.Deserialize(fs));

            foreach (var item in pNew)
            {
                Console.WriteLine(item);
            }
            fs.Close();
        }
    }
}
