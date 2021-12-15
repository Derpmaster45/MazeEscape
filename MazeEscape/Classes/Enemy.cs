using System;
using MazeEscape.Enums;
namespace MazeEscape.Classes
{
    public class Enemy
    {
        public string name { get; set; }
        public double attackPoints { get; set; }
        public double defensePoints{ get; set; }
        public double health { get; set; }

        // setters
        public string setName(EnemyTypes type) 
        {
            // switch statements go before return
            switch (type)
            {
                case EnemyTypes.BAT:
                    name = "Bat";
                    break;
                case EnemyTypes.CAVECRAWLER:
                    name = "Cave Cralwer";
                    break;
                case EnemyTypes.HORNET:
                    name = "Hornet";
                    break;
                case EnemyTypes.ZOMBIE:
                    name = "Zombie";
                    break;
            }
            return name;
        }
        public double setAttackPoints(EnemyTypes type)
        {
            //switch statements go before return, add more as they are added
            switch (type)
            {
                case EnemyTypes.BAT:
                    attackPoints = 20;
                    break;
                case EnemyTypes.CAVECRAWLER:
                    attackPoints = 45;
                    break;
                case EnemyTypes.HORNET:
                    attackPoints = 35;
                    break;
                case EnemyTypes.ZOMBIE:
                    attackPoints = 30;
                    break;

            }
            return attackPoints;
        }
        public double setDefensePoints(EnemyTypes type)
        {
            // switch statement goes here

            return defensePoints;
        }
        public double setHealth(EnemyTypes type)
        {
            // switch statement goes here
            switch (type)
            {
                case EnemyTypes.BAT:
                    health = 150;
                    break;
                case EnemyTypes.CAVECRAWLER:
                    health = 250;
                    break;
                case EnemyTypes.HORNET:
                   health= 200;
                    break;
                case EnemyTypes.ZOMBIE:
                    health = 100;
                    break;
            }
            return health;
        }
    }
}

