
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House();
            TeamLeader leader = new TeamLeader();
            house.Show();
        }

    }
}

    public interface IPart
    {
        bool Start();
        int Build_Part();
        bool Finish();
    }

    public enum basement { Ribbon = 1, Column, Monolithic, Pale, Plinth, Floating, Screw };

    public class Basement : IPart
    {
        private readonly basement b;

        public Basement()
        {

        }

        public Basement(basement bas)
        {
            b = bas;
        }

        public basement bas
        {
            get
            {
                Console.WriteLine("Type of basement: Ribbon - 1\n\t\t  Column - 2\n\t\t  Monolithic - 3\n\t\t  Pale - 4\n\t\t  Plinth - 5\n\t\t  Floating - 6\n\t\t  Screw - 7\n");
                Console.Write("Enter the type of basement: ");
                int x = int.Parse(Console.ReadLine());
                basement b = (basement)x;
                return b;
            }
        }

        public override string ToString()
        {
            return "Basement type: " + bas.ToString();
        }

        public int Build_Part()
        {
            return 1;
        }

        public bool Finish()
        {
            if (Build_Part() == 1)
            {
                Console.WriteLine("One basement was arranged.");
                return true;
            }
            else
                return false;
        }

        public bool Start()
        {
            return true;
        }
    }
    public enum walls { Brick = 1, FoamBlocks, Wood };

    public class Walls : IPart
    {
        Basement b { get; }
        private readonly walls w;

        public Walls()
        {

        }

        public Walls(walls wall)
        {
            w = wall;
        }

        public walls wall
        {
            get
            {
                Console.WriteLine("Wall material:\tBrick - 1\n\t\tFoamBlocks - 2\n\t\tWood - 3\n");
                Console.Write("Enter the wall material: ");
                int x = int.Parse(Console.ReadLine());
                walls w = (walls)x;
                return w;
            }
        }

        public override string ToString()
        {
            return "Wall with " + wall.ToString();
        }

        public int Build_Part()
        {
            if (b.Finish() == true)
                return 4;
            else
                return 0;
        }

        public bool Finish()
        {
            if (Build_Part() == 4)
            {
                Console.WriteLine("Four walls were built");
                return true;
            }
            else
                return false;
        }

        public bool Start()
        {
            if (b.Finish() == true)
                return true;
            else
                return false;
        }
    }
    public enum windows { Wood = 1, Plastic, Metal };

    public class Window : IPart
    {
        Walls w { get; }
        private readonly windows win;

        public Window()
        {

        }

        public Window(windows window)
        {
            win = window;
        }

        public windows window
        {
            get
            {
                Console.WriteLine("Window material: Wood - 1\n\t\t Plastic - 2\n\t\t Metal - 3\n");
                Console.Write("Enter the window material: ");
                int x = int.Parse(Console.ReadLine());
                windows win = (windows)x;
                return win;
            }
        }

        public override string ToString()
        {
            return "Window with " + window.ToString();
        }


        public int Build_Part()
        {
            if (w.Finish() == true)
                return 4;
            else
                return 0;
        }

        public bool Finish()
        {
            if (Build_Part() == 4)
            {
                Console.WriteLine("Four windows are installed.");
                return true;
            }
            else
                return false;
        }

        public bool Start()
        {
            if (w.Finish() == true)
                return true;
            else
                return false;
        }
    }
    public enum doors { Wood = 1, Plastic, Metal, DSP, DVP };

    public class Door : IPart
    {
        Walls w { get; }
        private readonly doors d;

        public Door()
        {

        }

        public Door(doors door)
        {
            d = door;
        }

        public doors door
        {
            get
            {
                Console.WriteLine("Door material: Wood - 1\n\t\t Plastic - 2\n\t\t Metal - 3\n\t\t DSP - 4\n\t\t DVP - 5\n");
                Console.Write("Enter the door material: ");
                int x = int.Parse(Console.ReadLine());
                doors d = (doors)x;
                return d;
            }
        }

        public override string ToString()
        {
            return "Door with " + door.ToString();
        }


        public int Build_Part()
        {
            if (w.Finish() == true)
                return 1;
            else
                return 0;
        }

        public bool Finish()
        {
            if (Build_Part() == 1)
            {
                Console.WriteLine("One door is installed.");
                return true;
            }
            else
                return false;
        }

        public bool Start()
        {
            if (w.Finish() == true)
                return true;
            else
                return false;
        }
    }
    enum roofs { Tiling = 1, MetalProfile, Shingles };

    class Roof : IPart
    {
        Walls w { get; }
        private readonly roofs r;

        public Roof()
        {

        }

        public Roof(roofs roof)
        {
            r = roof;
        }

        public roofs roof
        {
            get
            {
                Console.WriteLine("Roof material: Tiling - 1\n\t\t MetalProfile - 2\n\t\t Shingles - 3\n");
                Console.Write("Enter the roof material: ");
                int x = int.Parse(Console.ReadLine());
                roofs r = (roofs)x;
                return r;
            }
        }

        public override string ToString()
        {
            return "Roof with " + roof.ToString();
        }


        public int Build_Part()
        {
            if (w.Finish() == true)
                return 1;
            else
                return 0;
        }

        public bool Finish()
        {
            if (Build_Part() == 1)
            {
                Console.WriteLine("One roof is built.");
                return true;
            }
            else
                return false;
        }

        public bool Start()
        {
            if (w.Finish() == true)
                return true;
            else
                return false;
        }
    }
    public class House : IPart
    {
        List<IPart> parts;

        public House()
        {
            parts = new List<IPart>();
            parts.Add(new Basement());
            parts.Add(new Walls());
            parts.Add(new Door());
            parts.Add(new Window());
            parts.Add(new Roof());
        }

        public int Build_Part()
        {
            return 1;
        }

        public bool Finish()
        {
            return true;
        }

        public bool Start()
        {
            return true;
        }

        public void Show()
        {

            Console.WriteLine("\n\t\t                               /\\");
            Console.WriteLine("\t\t                              /  \\");
            Console.WriteLine("\t\t                             /    \\");
            Console.WriteLine("\t\t                            /      \\");
            Console.WriteLine("\t\t                           /        \\");
            Console.WriteLine("\t\t                          /          \\");
            Console.WriteLine("\t\t                         /            \\");
            Console.WriteLine("\t\t                      __/___           \\");
            Console.WriteLine("\t\t                      |    |            \\");
            Console.WriteLine("\t\t                      |    |             \\");
            Console.WriteLine("\t\t                     /|    |             /|");
            Console.WriteLine("\t\t                    / |    |            / |");
            Console.WriteLine("\t\t                   /  |    |           /  |");
            Console.WriteLine("\t\t                  /                   /   |");
            Console.WriteLine("\t\t                 /                   / /| |");
            Console.WriteLine("\t\t                /                   / / | |");
            Console.WriteLine("\t\t               /                   / /  | |");
            Console.WriteLine("\t\t              /                   /  |  | |");
            Console.WriteLine("\t\t             /                   /   |* |/|");
            Console.WriteLine("\t\t            /                   /    |  //");
            Console.WriteLine("\t\t           /                   //|   | //");
            Console.WriteLine("\t\t          /                   // |   |//");
            Console.WriteLine("\t\t         /\\                  //| |   //");
            Console.WriteLine("\t\t        /  \\                // | |  //");
            Console.WriteLine("\t\t       /    \\              / | | / //");
            Console.WriteLine("\t\t      /      \\            /  | |/ //");
            Console.WriteLine("\t\t     /        \\          /   | / //");
            Console.WriteLine("\t\t    /          \\        //|  |/ //");
            Console.WriteLine("\t\t   /            \\      // |    //");
            Console.WriteLine("\t\t  /              \\    //| |   //");
            Console.WriteLine("\t\t /                \\  // | |  //");
            Console.WriteLine("\t\t/__________________\\/ | | / //");
            Console.WriteLine("\t\t|                  |  | |/ //");
            Console.WriteLine("\t\t|     ________     |  | / //");
            Console.WriteLine("\t\t|    |    |   |    |  |/ //");
            Console.WriteLine("\t\t|    |    |   |    |    //");
            Console.WriteLine("\t\t|    |    |   |    |   //");
            Console.WriteLine("\t\t|    |____|___|    |  //");
            Console.WriteLine("\t\t|                  | //");
            Console.WriteLine("\t\t|__________________|//");
            Console.WriteLine("\t\t|__________________|/");
        }
    }
    public interface IWorker
    {
        void AskForReady(House newHouse);

        void StartBuilding(House newHouse, IPart newPart);

        void Report(IPart newPart);
    }
    class Worker : IWorker
    {
        public void AskForReady(House newHouse)
        {
            Console.WriteLine("Which is built?");
        }

        public void Report(IPart newPart)
        {
            Console.WriteLine("\nBuilt " + newPart);
        }

        public void StartBuilding(House newHouse, IPart newPart)
        {
            Console.WriteLine("Start of build");
        }
    }
    public class Team : IWorker
    {
        Worker worker = new Worker();

        public void AskForReady(House newHouse)
        {
            worker.AskForReady(newHouse);
        }

        public void Report(IPart newPart)
        {
            worker.Report(newPart);
        }

        public void StartBuilding(House newHouse, IPart newPart)
        {
            worker.StartBuilding(newHouse, newPart);
        }
    }
    class TeamLeader : IWorker
    {
        Team team = new Team();

        public void AskForReady(House newHouse)
        {
            team.AskForReady(newHouse);
        }

        public void Report(IPart newPart)
        {
            team.Report(newPart);
        }

        public void StartBuilding(House newHouse, IPart newPart)
        {
            team.StartBuilding(newHouse, newPart);
        }
    }