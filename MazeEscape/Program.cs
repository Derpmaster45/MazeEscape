﻿using System;
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

            }
            if(option.ToLower()=="go north") 
            {
                if (weaponOfChoice == WeaponsEnum.SHORTSWORD) 
                {
                    Console.WriteLine("You come across a thicket it looks peaceful. What would you like to do?");
                    string actionChoice = Console.ReadLine();
                    if(actionChoice.ToLower()=="Cut it down") 
                    {
                        Console.WriteLine("You took a swing at the thicket.\n Do you want to continue cutting it down?");
                        actionChoice = Console.ReadLine().ToLower();
                        int i = 0;
                        do
                        {

                            Console.WriteLine("You continue to cut down the thicket?\n Do you want to continue cutting it down");
                            actionChoice = Console.ReadLine().ToLower();
                            if (actionChoice.ToLower() == "Yes") 
                            {
                                i++;
                            }
                            else 
                            {
                                break;
                             }

                        } while (i < 5);                  
                            
                        }

                }
            }
        }
        
    }
}
