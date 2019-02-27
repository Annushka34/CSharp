using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Lesson_String
{
    class Char
    {
        static void Main(string[] args)
        {
            char a = 'a';
            Console.WriteLine($"char.IsDigit(a) = {char.IsDigit(a)}");
            Console.WriteLine($"char.IsLetter(a) = {char.IsLetter(a)}");
            Console.WriteLine($"char.IsLower(a) = {char.IsLower(a)}");

        }
    }
}
