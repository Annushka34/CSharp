using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_CreateDirsFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            //WORK_WITH_FOLDER();
            WORK_WITH_FILES();
        }
        static void WORK_WITH_FILES()
        {
            //---CREATE---
            FileInfo fi = new FileInfo(@"D:\TEST\picture.jpg");
            for (int i = 0; i < 20; i++)
            {
                fi.CopyTo(@"D:\TEST\new" + i + fi.Extension);
            }
            //---DELETE---
            //fi.Delete();//---no mistake if no exist
            //if (fi.Exists)
            //{
            //    Console.WriteLine("EXIST");
            //}
            //else
            //{
            //    fi.Create();//---no mistake if exist, but rewrite
            //    Console.WriteLine("CREATE NEW FILE");
            //}
            //---COPY---
            //---create new file, if exist will be exception
            // FileInfo newCopy = fi.CopyTo(@"D:\TEST2\newTestStep.txt");
            //File.Create("D:\")
            //FileInfo newCopy = new FileInfo(@"D:\TEST\includedFolder\newTestStep2.txt");
            ////---MOVE---(the same as rename)
            //newCopy.MoveTo(@"D:\TEST\includedFolder\newName.txt");


            //--------------------------------------
            FileStream fs = File.Create(@"D:\TEST\includedFolder\newName2222.txt");
            fs.Close();
            string text = Console.ReadLine();
            //----rewrite----
            //  File.WriteAllText(@"D:\TEST\includedFolder\newName2222.txt", text);
            //  File.Encrypt(@"D:\TEST\includedFolder\newName2222.txt");        }
        }

            static void WORK_WITH_FOLDER()
        {
            Console.WriteLine("Enter disc name: ");
            string dirName = Console.ReadLine();

            DirectoryInfo dir = new DirectoryInfo(dirName + @":\");
            DirectoryInfo newDirLevel1 = null;
            //----CASE 1   CREATE DIR-----
            if (dir.Exists)
            {
                Console.WriteLine(dir.FullName);
                newDirLevel1 = dir.CreateSubdirectory("testNewDir");
                DirectoryInfo newDirLevel2 = newDirLevel1.CreateSubdirectory("includedFolder");
                DirectoryInfo newDirLevel1DiscD = dir.CreateSubdirectory(@"ШАГ\newFolder");
            }
            //----CASE 2   CREATE DIR-----
            DirectoryInfo newNewNewDir = Directory.CreateDirectory(@"D:\ШАГ\newFolder\newNewNewFolder");
            //----cant delete if no empty
            //newDirLevel1.Delete(false);

            //----delete all with included files and folders
            //newDirLevel1.Delete(true);
            //newNewNewDir.Delete();

            //----all included moved
            newDirLevel1.MoveTo(@"D:\TEST");
        }
    }
}
