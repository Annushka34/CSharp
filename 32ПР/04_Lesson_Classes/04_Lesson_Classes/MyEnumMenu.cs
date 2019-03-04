using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Lesson_Classes
{
    public enum MyEnum { Show, ShowAll, Add, Remove };
    public class MyEnumMenu
    {
        private string[] menuCases = new string[] { "Show", "Show all", "Add", "Remove" };
        private void ShowMenu(int light)
        {
            for (int i = 0; i < menuCases.Length; i++)
            {
                if (light == i)
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(menuCases[i]);
                Console.ResetColor();
            }
        }
        public MyEnum MakeChoice()
        {
                int i = 0;
                ConsoleKey consoleKey = ConsoleKey.Clear;
                ShowMenu(i);
                while ((consoleKey = Console.ReadKey().Key) != ConsoleKey.Enter)
                {
                    Console.Clear();
                    switch (consoleKey)
                    {
                        case ConsoleKey.DownArrow:
                            {
                                i = i < menuCases.Length - 1 ? i + 1 : 0;
                                break;
                            }
                        case ConsoleKey.UpArrow:
                            {
                                i = i > 0 ? i - 1 : menuCases.Length - 1;
                                break;
                            }
                    }
                    ShowMenu(i);
                }
                return (MyEnum)i;
        }

        public MyEnum MakeChoiceSimple()
        {
            int i = 0;
            while (true)
            {
                ShowMenu(i);
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                Console.Clear();
                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.DownArrow:
                        {
                            i = i < menuCases.Length - 1 ? i + 1 : 0;
                            break;
                        }
                    case ConsoleKey.UpArrow:
                        {
                            i = i > 0 ? i - 1 : menuCases.Length - 1;
                            break;
                        }
                    case ConsoleKey.Enter:
                        {
                            if (Enum.IsDefined(typeof(MyEnum), i))
                            {
                                return (MyEnum)i;
                            }
                            break;
                        }
                }
            }            
        }


        public void ShowAllCases()
        {
            var enumVals = Enum.GetNames(typeof(MyEnum));
            foreach (var item in enumVals)
            {
                Console.WriteLine(item);
            }
        }
    }
}
