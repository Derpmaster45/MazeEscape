using System;
using MazeEscape.Classes;
using MazeEscape.Enums;
using MazeEscape.ExperimentalClasses;

namespace MazeEscape
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // object instance creation
            WeaponsEnum weaponOfChoice= new WeaponsEnum();
            WeaponSTATS stats = new WeaponSTATS();
            
            //PlayerStats pStats =();

            // stats setup
            // pStats.setHealth = 100;
            double weaponDamage;

            // intro and first choice
            #region 
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
                            //Console.WriteLine($"The damage for {weaponOfChoice} is {weaponDamage}");
                            break;
                        case "NO":
                        case "no":
                        case "N":
                        case "n":
                        case "Leave short sword alone":
                        case "LEAVE SHORT SWORD ALONE":
                        case "leave short sword alone":

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
                    Console.WriteLine("Command not recognised");
                    break;
                    #endregion
            }
            if (option.ToLower()=="go north") 
            {
                if (weaponOfChoice == WeaponsEnum.SHORTSWORD) 
                {
                    Console.WriteLine("You come across a thicket it looks peaceful, but somewhat hard to walk through. What would you like to do?");
                    string actionChoice = Console.ReadLine();
                    switch (actionChoice)
                    {
                        case "Cut down thicket":
                        case "cut down thicket":
                            Console.WriteLine("You took a swing at the thicket, and successfully cutting some of the thicket. \n" +
                                "Do you continue cutting the thicket?");
                            actionChoice = Console.ReadLine().ToLower();
                            int actionCount = 0;
                            while (actionChoice.ToLower()=="yes" || actionChoice.ToLower() == "y"&&actionCount<=5) 
                            {
                                Console.Write("You continue to cut the thicket, you hear a roar that gets louder as you continue to cut.\n" +
                                    "Would you like to continue cutting the thicket?");
                                actionChoice = Console.ReadLine().ToLower();
                               
                             }

                            break;

                            
                    }

                }
            }
        }
        
    }
}
