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
            while (target.health > 0)
            {
                // introduce the battle
                Console.WriteLine($"You encounter a {type.ToString().ToLower()}, what would you like to do?");
                // show the menu!
                Console.WriteLine("Menu:\n 1: Physical Attack\n 2: Magic Attack\n 3: Defend\n 4: Retreat");
                // set action to 0 to keep from defaulting to an action.
                int action = 0;
                int.TryParse(Console.ReadLine(), out action);
                switch (action)
                {
                    case 1:
                        break;
                    case 2:
                        // insert action code here
                        break;
                    case 3:
                        // insert action code here
                        break;
                    case 4:
                        // insert action code here
                        break;

                }
            }

        }
    }
}