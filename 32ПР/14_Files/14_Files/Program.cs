using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Files
{
    class Program
    {
        ////DirectoryInfo
        ////FileInfo
        ////Directory
        ////File
        static void Main(string[] args)
        {
            //string[] dirs = Directory.GetLogicalDrives();
            DriveInfo[] dirs = DriveInfo.GetDrives();
            DirectoryInfo[] subDirs = null;
            foreach (var d in dirs)
            {
                Console.WriteLine(d.Name);
                if (d.IsReady)
                {
                    Console.WriteLine(d.TotalFreeSpace / 1024 / 1024 / 1024 + "Gb");
                    Console.WriteLine(d.TotalSize / 1024 / 1024 / 1024 + "Gb");
                   
                }
            }

            int num = int.Parse(Console.ReadLine());
            if (dirs[num - 1].IsReady)
            {
                DirectoryInfo dir = new DirectoryInfo(dirs[num - 1].Name);

                subDirs = dir.GetDirectories();
                Head("ALL folders in drive " + dir.FullName);
                for (int i = 0; i < subDirs.Length; i++)
                {
                    Console.WriteLine("["+i+"] "+subDirs[i].FullName);
                }
            }
            else
            {
                Head("NO ACCESS");
            }

            if (dirs[num - 1].IsReady)
            {
                DirectoryInfo dir = new DirectoryInfo(dirs[num - 1].Name);

                FileInfo[] files = dir.GetFiles();
                Head("ALL files in drive " + dir.FullName);
                foreach (var item in files)
                {
                    Console.Write(item.FullName);
                    Console.Write("   ext "+item.Extension);
                    Console.WriteLine("   name: "+item.Name);
                }
            }
            else
            {
                Head("NO ACCESS");
            }

            Console.WriteLine("SELECT SUBFOLDER: ");
            int indFolder = int.Parse(Console.ReadLine());
            ShowDirs (subDirs[indFolder]);
        }
        static void Head(string head)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---------------" + head + "--------------------");
            Console.ResetColor();
        }

        static void ShowDirs(DirectoryInfo dir)
        {
            DirectoryInfo[] subDirSelected = dir.GetDirectories();
            Head("ALL folders in drive " + dir.FullName);
            for (int i = 0; i < subDirSelected.Length; i++)
            {
                Console.WriteLine("[" + i + "] " + subDirSelected[i].FullName);
            }
        }
    }

}
