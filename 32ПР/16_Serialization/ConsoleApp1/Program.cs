using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _26._03._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            //Figure f = new Figure(10, 100, 25);
            // SoapFormatter sF = new SoapFormatter();
            // //FileStream file = new FileStream("soapFile.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            // //sF.Serialize(file, f);
            //// file.Close();
            // FileStream file1 = new FileStream("soapFile.txt", FileMode.Open, FileAccess.Read);
            // Figure fNew = null;
            // fNew = (Figure)sF.Deserialize(file1);
            // Console.WriteLine(fNew);
            // file1.Close();
            ///////////////////////////////////////////////////////////////////////////////////////////
            // Figure f = new Figure(100, 200, 250);
            //BinaryFormatter Bf = new BinaryFormatter();
            //FileStream file = new FileStream("BinaryFile.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //Bf.Serialize(file, f);
            //file.Close();
            // FileStream file1 = new FileStream("BinaryFile.txt", FileMode.Open, FileAccess.Read);
            // Figure fNew = null;
            //fNew = (Figure)Bf.Deserialize(file1);
            //Console.WriteLine(fNew);
            //file1.Close();
            ////////////////////////////////////////////////////////////////////////
            //  Figure f = new Figure(555, 333, 111);
            XmlSerializer xml = new XmlSerializer(typeof(Figure));
            //    FileStream file = new FileStream("XMLFile.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //  xml.Serialize(file, f);
            // file.Close();

            //JavaScriptSerializer java = new JavaScriptSerializer();


        }
    }
}