using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _16_Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Firm f = new Firm(5, "SuperCoolGuys");

            BinaryFormatter bf = new BinaryFormatter();
           // FileStream fs = new FileStream("firmData.txt", FileMode.Truncate, FileAccess.Write);
            //bf.Serialize(fs, f);

            FileStream fs = new FileStream("firmData.txt", FileMode.OpenOrCreate, FileAccess.Read);
            Firm fNew = null;
            fNew = (Firm)bf.Deserialize(fs);
            Console.WriteLine(fNew);
            fs.Close();
        }
    }
}
