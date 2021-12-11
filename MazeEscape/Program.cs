using System;

namespace MazeEscape
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // object instance creation
            WeaponsEnum weaponOfChoice= new WeaponsEnum();
            WeaponSTATS stats = new WeaponSTATS();
            double weaponDamage;
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

                            weaponOfChoice = WeaponsEnum.SHORTSWORD;
                            Console.WriteLine($"You picked up the {weaponOfChoice}.\n You have no idea why it is here, but in just in case, you take it with you.");
                            weaponDamage=stats.setDamage(weaponOfChoice);
                            Console.WriteLine($"The damage for {weaponOfChoice} is {weaponDamage}");
                            break;

                        default:
                            Console.WriteLine("Command not recognized");
                            break;

                    }
                    break;
                    // case for heading south
                case "Go south":
                case "Go South:":
                case "go south":
                    Console.WriteLine("You head down the path that leads south.\n On that path you find a slingshot do you pick it up?");
                    break;
                default:
                    Console.WriteLine("There are 4 pathways. You can:\n\" +\n            \t\"Go North\n\" +\n            \t\"Go South\n\" +\n            \t\"Go East\n\" +\n          " +
                    	"\t\"Go West\"");
                    break;
            }
        }
    }
}
