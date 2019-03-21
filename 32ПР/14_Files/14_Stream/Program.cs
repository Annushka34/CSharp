using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _14_Stream
{
    class Program
    {
        static void Main(string[] args)
        {
            string dir = @"D:\";
            string folder = "TEST";
            //  string filename = "testFile.txt";
            string filename = "banana.png";
            string path =  Path.Combine(dir, folder, filename);
            Console.WriteLine(Path.GetDirectoryName(path));
            Console.WriteLine(Path.GetExtension(path));
            Console.WriteLine(Path.GetFullPath(path));
            Console.WriteLine(Path.GetFileName(path));

            // ReadWriteFileStream(path);
            // ReadWriteFileReaderWriter(path);
            ReadWriteBinaryReaderWriter(path);

        }
        static void ReadWriteBinaryReaderWriter(string path)
        {
            byte[] foto = null;
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader sw = new BinaryReader(fs))
                {
                    foto = sw.ReadBytes((int)fs.Length);
                    Console.WriteLine();
                    Console.WriteLine(foto.Length);
                    Random r = new Random();
                    for (int i = 2001; i < foto.Length-900; i+=800)
                    {
                        if (foto[i] < 50)
                            foto[i] = 0;
                       // Thread.Sleep(50);
                    }
                    Console.WriteLine();
                }
            }

            string dir = Path.GetDirectoryName(path);
            string ext = Path.GetExtension(path);

            for (int i = 0; i < 10; i++)
            {
                string newPath = Path.Combine(dir, "DearClient" + Guid.NewGuid() + ext);
                using (FileStream fs = new FileStream(newPath, FileMode.Append, FileAccess.Write))
                {
                    using (BinaryWriter sw = new BinaryWriter(fs))
                    {
                        sw.Write(foto);
                    }
                }
            }
        }
            static void ReadWriteFileReaderWriter(string path)
        {
            //StreamWriter sw = new StreamWriter(path, true);
            //sw.Write("test 2222222222222222222");
            //sw.Write(123);
            //sw.Close();

            //StreamReader sr = new StreamReader(path);
            //string str = sr.ReadToEnd();
            //Console.WriteLine(str);


            using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write("111111111111111111111111111aaaaaaaaa");
                    sw.Write("qqqqqqqqqq   ggggggg");
                }
            }
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sw = new StreamReader(fs))
                {
                    Console.WriteLine(sw.ReadToEnd());
                }
            }

        }


            static void ReadWriteFileStream(string path)
        {
            //FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //fs.Close();

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                string text = Console.ReadLine();
                byte[] textByte = Encoding.UTF8.GetBytes(text);
                fs.Write(textByte, 0, textByte.Length);
            }


            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                byte[] textByte = new byte[fs.Length];
                fs.Read(textByte, 0, textByte.Length);
                string text = Encoding.Default.GetString(textByte);
                Console.WriteLine(text);
            }
        }
    }
}
