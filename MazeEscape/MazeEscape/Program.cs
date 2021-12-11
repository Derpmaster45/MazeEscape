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
                    Console.WriteLine("You head down the path heading north, on the path you find a short sword. Do you want to pick it up?");
                    string actionChoice = Console.ReadLine();
                    switch (actionChoice)
                    {
                        case "YES": 
                        case "yes":
                        case "y":
                        case "Y":
                        case "Pick up short sword":
                        case "pick up short sword":
                            Console.WriteLine("");
                            break;
                        default:
                            Console.WriteLine("Command not recognized");

                    }
                    break;
                default:
                    Console.WriteLine("There are 4 pathways. You can:\n\" +\n            \t\"Go North\n\" +\n            \t\"Go South\n\" +\n            \t\"Go East\n\" +\n            \t\"Go West\");");
                    break;
            }
        }
    }
}
