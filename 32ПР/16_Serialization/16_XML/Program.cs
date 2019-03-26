using _16_Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _16_XML
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
            ////---Have been default constructor and only public field will be serialized
            //XmlSerializer xml = new XmlSerializer(typeof(List<Person>));

            //FileStream fs = new FileStream("personsListDataXml.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //xml.Serialize(fs, p);
            //fs.Close();



            //Firm f = new Firm(7, "SuperCoolGuys");
            //XmlSerializer xml = new XmlSerializer(typeof(Firm));

            //FileStream fs = new FileStream("firmDataXml2.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //xml.Serialize(fs, f);
            //fs.Close();


            Firm newF = null;
            XmlSerializer xml = new XmlSerializer(typeof(Firm));
            FileStream fs = new FileStream("firmDataXml2.txt", FileMode.Open, FileAccess.ReadWrite);
            newF = (Firm)xml.Deserialize(fs);
            Console.WriteLine(newF);
            fs.Close();

            List<Person> persons = null;
            XmlSerializer xml2 = new XmlSerializer(typeof(List<Person>));
            FileStream fs2 = new FileStream("personsListDataXml.txt", FileMode.Open, FileAccess.ReadWrite);
            persons = (List<Person>)xml2.Deserialize(fs2);
            foreach (var item in persons)
            {
                Console.WriteLine(item);
            }
            fs2.Close();
        }
    }
}
