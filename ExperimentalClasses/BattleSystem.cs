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
        public WeaponSTATS damageDealt;

        // battlesystem fuction
        public void battleStart(EnemyTypes type)
        {
            double weaponDamage;
            while (target.health > 0)
            {
                // introduce the battle
                Console.WriteLine($"You encounter a {type.ToString().ToLower()}, what would you like to do?");
                // show the menu!
                Console.WriteLine("Menu:\n 1: Physical Attack\n 2: Retreat\n");
                // set action to 0 to keep from defaulting to an action.
                int action = 0;
                //double weaponDamage;
                int.TryParse(Console.ReadKey().ToString(), out action);
                switch (action)
                {
                    case 1:
                        switch (weapons) 
                        {
                            case WeaponsEnum.BOW:
                                //damageDealt = 35.0;
                               weaponDamage= damageDealt.damage;
                                break;
                            case WeaponsEnum.SHORTSWORD:
                                weaponDamage = damageDealt.damage;
                                break;
                            case WeaponsEnum.FISTS:
                                weaponDamage = damageDealt.damage;
                                break;
                            case WeaponsEnum.SPEAR:
                                weaponDamage = damageDealt.damage;
                                break;
                         }
                        //Console.WriteLine($"You attacked and did {weaponDamage.ToString()}");

                        break;
                    case 2:
                        // insert  action code here
                        break;

                }
            }

        }
    }
}