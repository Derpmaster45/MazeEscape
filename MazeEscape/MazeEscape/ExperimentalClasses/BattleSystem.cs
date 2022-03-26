using System;
using MazeEscape.Enums;
using MazeEscape.Classes;
namespace MazeEscape.ExperimentalClasses
{
    public class BattleSystem
    {
        // object declaration
        public Enemy target = new Enemy();
        PlayerStats player = new PlayerStats();
        private WeaponsEnum weapons { get; set; }

        // battlesystem fuction
        public void battleStart(EnemyTypes type)
        {
            while (target.health > 0|| player.health>0)
            {
                // introduce the battle
                Console.WriteLine($"You encounter a {type.ToString().ToLower()}, what would you like to do?");
                // show the menu!
                Console.WriteLine("Menu:\n 1: Physical Attack\n 2: Defend\n 3: Retreat");
                // set action to 0 to keep from defaulting to an action.
                int action = 0;
                int.TryParse(Console.ReadLine(), out action);
                switch (action)
                {
                    case 1:
                        // create a get weapon type and deal damage from there
                        break;
                    case 2:
                        // insert action code here
                        break;
                    case 3:
                        // do math to figure out if player was sucessful in retreating
                        Console.WriteLine("You retreated");
                        break;
                   

                }
            }

        }
        public void retreat() 
        {
           // if(player.speed<target.)
         }
        public void defendPlayer() 
        {
         
         }
    }

}