using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _14_MemmoryStream
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] data = new byte[255];
            // Создаём запоминающий поток
            MemoryStream mStream = new MemoryStream(data);
            // Создаём объекты чтения и записи данных в потоки
            // и передаём mStream в качестве параметра
       
            StreamWriter sWriter = new StreamWriter(mStream);

            // Записываем данные в память
            for (int i = 0; i < 4; i++)
            {
                // sWriter.WriteLine("byte [" + i + "]: " + i);
                string strReaded = Console.ReadLine();
                sWriter.WriteLine(strReaded);
            }
            // Записываем в память символ для того, чтобы в цикле
            // при достижении этого символа, выйти из цикла.
            // В противном случае мы пробежимся по всем 255 символам.
            sWriter.WriteLine("!");
            // Данный метод нужен для того, чтобы содержимое буфера этого объекта 
            // записалось непосредственно в массив data.
            // Если этого не сделать, то в массиве data ничего не будет.
            sWriter.Flush();

            // Читаем данные прямо из массива data.
            //Console.WriteLine("Данные из массива data:");
            //foreach (char ch in data)
            //{
            //    if (ch == '!') break;
            //    Console.Write(ch);
            //}

            //-----------------------------------READ--------------------------------------------

            StreamReader sReader = new StreamReader(mStream);
            // Читаем данные из потока с помощью StreamReader
            Console.WriteLine("Читаем данные из потока MemoryStream:");
            // Ставим указатель файла в начала запоминающего потока MemoryStream.
            // Если этого не сделать, то вывод будет пустым.
            mStream.Seek(0, SeekOrigin.Begin);
            string str = "";
            while ((str = sReader.ReadLine()) != null)
            {
                if (str == "!") break;
                Console.WriteLine(str);
            }
            Console.ReadLine();
        }
    }
}
