using System;

namespace MazeEscape
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // intro and first choice
            Console.WriteLine("You wake up, and you don't know where you are. There are 4 pathways. You can:\n" +
            	"Go North\n" +
            	"Go South\n" +
            	"Go East\n" +
            	"Go West");
            Console.WriteLine("What will you choose?");
            string option = Console.ReadLine();
            // use a switch statement to bulkify the statements
            switch (option)
            {
                case "Go North":
                case "go north":
                case "GO NORTH":
                    break;
                default:
                    Console.WriteLine("");
                    break;
            }
        }
    }
}
