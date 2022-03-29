using System;
using MazeEscape.Classes;
using MazeEscape.Enums;
using MazeEscape.ExperimentalClasses;

namespace MazeEscape
{
    class MainClass
    {
        public double dealDamage(double pAttack, double eHealth, double eDefence)
        {
            double damageDealt = pAttack - (eHealth * eDefence);
            return damageDealt;
        }
        public static void Main(string[] args)
        {
            // object instance creation
            WeaponsEnum weaponOfChoice = new WeaponsEnum();
            WeaponSTATS stats = new WeaponSTATS();
            EnemyTypes type = new EnemyTypes();
            Enemy eStats = new Enemy();

            //PlayerStats pStats =();

            // stats setup
            // pStats.setHealth = 100;
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
                            weaponDamage = stats.setDamage(weaponOfChoice);
                            //Console.WriteLine($"The damage for {weaponOfChoice} is {weaponDamage}");
                            break;
                        case "NO":
                        case "no":
                        case "N":
                        case "n":
                        case "Leave short sword alone":
                        case "LEAVE SHORT SWORD ALONE":
                        case "leave short sword alone":
                            Console.WriteLine("You leave the short sword alone thinking that you may not need it.");
                            weaponOfChoice = WeaponsEnum.FISTS;

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
                    Console.WriteLine("Command not recognised");
                    break;

            }
            if (option.ToLower() == "go north")
            {
                if (weaponOfChoice == WeaponsEnum.SHORTSWORD)
                {
                    Console.WriteLine("You come across a thicket it looks peaceful. What would you like to do?");
                    string actionChoice = Console.ReadLine().ToLower();
                    switch (actionChoice) 
                    {
                        case "cut it down":
                            int i = 0;
                            do { Console.WriteLine($"You took a swing at the the thicket with the {weaponOfChoice.ToString().ToLower()}");

                                Console.WriteLine("Would you like to continue Y/n");
                                string gameContinue= Console.ReadLine().ToLower();
                                if (gameContinue.ToLower() == "yes"|| gameContinue.ToLower()=="y")
                                {
                                    i++;
                                }
                                else
                                {
                                    Console.WriteLine("You stopped cutting the thicket and work your way through the remaining thicket." +
                                    	"When you get out of the thicket, you come across a stream teaming with wildlife. This is the end of the demo.");

                                    break;
                                }

                            }

                            while (i < 5 );
                            if (i == 5)

                            {
                                while (eStats.getHealth(type) > 0)
                                {
                                    type = EnemyTypes.BAT;
                                    Console.WriteLine($"You have encountered a {type}");
                                    Console.WriteLine("What would you like to do?");
                                    actionChoice = Console.ReadLine().ToLower();
                                    switch (actionChoice)
                                    {
                                        case "attack":
                                            dealDamage()
                                            break;
                                        case "retreat":
                                            break;
                                        default:
                                            Console.WriteLine("Command not recognized.");
                                            break;
                                    }

                                }
                            }
                            break;

                    }

                }
            }
        }
    }

}