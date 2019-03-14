using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _10_Exeptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: this code is not important! remove this!!!
            //try
            //{
            //    int[] arr = new int[0];
            //    for (int i = 0; i < 5; i++)
            //    {
            //        Console.WriteLine(arr[i]);
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("Error!!!!!");
            //}

            Foo();
            //try
            //{
            //    MoreSpeed();
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine("Source: "+ex.Source);
            //    Console.WriteLine("StachTrace: "+ex.StackTrace);
            //    Console.WriteLine("Inner exeption: "+ex.InnerException);
            //    Console.WriteLine("Method: " + ex.TargetSite);
            //}


            try
            {
                //MoreSpeed2();
                MoreSpeed3();
            }
            catch(MyEx ex)
            {
                Console.WriteLine(ex.Message);
            }
            //catch(IndexOutOfRangeException ex1)
            //{

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine("Source: " + ex.Source);
            //   // Console.WriteLine("StachTrace: " + ex.StackTrace);
            //    Console.WriteLine("Inner exeption: " + ex.InnerException);
            //    Console.WriteLine("Method: " + ex.TargetSite);
            //    Console.WriteLine("Help link: " + ex.HelpLink);
            //    foreach (DictionaryEntry item in ex.Data)
            //    {
            //        Console.WriteLine(item.Key + ":  "+item.Value);
            //    }
            //}

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---------MY IMPORTANT CODE-----------");
            Console.WriteLine("Wait a minute....");
            Console.WriteLine("Continue....");
        }


        static void Foo()
        {
            try
            {
                byte b = 100;
                byte c = checked((byte)(300 + b));
            }
            catch (Exception ex)
            {
                // Console.WriteLine(ex.Message);
                // Console.WriteLine(ex.Source);
                // Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Method: "+ex.TargetSite);
                var exInfo = ex.TargetSite.GetMethodBody();
                Console.WriteLine("Method: " + ex.TargetSite.MemberType);
            }
        }


        static void MoreSpeed()
        {
            //TODO: refactor this code!!! dont forget it
            int speed = 0;
            Console.WriteLine("Car start drive...");
            while(true)
            {
                speed++;
                Thread.Sleep(50);
                Console.WriteLine(speed);
                if (Console.KeyAvailable)
                {
                    var keyInfo = Console.ReadKey();
                    break;
                }
                    if (speed > 30)
                        throw new Exception("speed cant be more!!!! You are die!");
            }
        }


        //static void MoreSpeed2()
        //{
        //    int speed = 0;
        //    Console.WriteLine("Car start drive...");
        //    while (true)
        //    {
        //        speed++;
        //        Thread.Sleep(50);
        //        Console.WriteLine(speed);
        //        if (Console.KeyAvailable)
        //        {
        //            var keyInfo = Console.ReadKey();
        //            break;
        //        }
        //        try
        //        {
        //            if (speed > 30)
        //                throw new Exception("speed cant be more!!!! You are die!");
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e.Message);
        //            //throw; //   the same exeption go on top
        //            Exception myEx = new Exception("ERROR!!! CAR and DRIVER NO EXIST ANY MORE", e);//---new exeption go on top
        //            myEx.HelpLink = @"http://www.cyberforum.ru/csharp-beginners/thread2186074.html";
        //            myEx.Data.Add("DateTime", DateTime.Now);
        //            myEx.Data.Add("Developer", "AnnPilaeva");
        //            //----save to log file----
        //            throw myEx;
        //        }
        //    }

        static void MoreSpeed3()
        {
            int speed = 0;
            Console.WriteLine("Car start drive...");
            while (true)
            {
                speed++;
                Thread.Sleep(50);
                Console.WriteLine(speed);
                if (Console.KeyAvailable)
                {
                    var keyInfo = Console.ReadKey();
                    break;
                }
                try
                {
                    if (speed > 30)
                        throw new Exception("speed cant be more!!!! You are die!");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    //throw; //   the same exeption go on top
                    throw new MyEx("ERROR IN LINE 170"); 
                }
            }
        }
    }
}
