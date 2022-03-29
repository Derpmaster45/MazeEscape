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
        public void setName(EnemyTypes type) 
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

        }
        public string getName(EnemyTypes types)
        {
            return name;
        }
        public void setAttackPoints(EnemyTypes type)
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

        }
        public double getAttackPoints(EnemyTypes types)
        {
            return attackPoints;
        }

        public void setDefensePoints(EnemyTypes type)
        {
            // switch statement goes here
            switch (type)
            {
                case EnemyTypes.BAT:
                    defensePoints = 20;
                    break;
                case EnemyTypes.CAVECRAWLER:
                    defensePoints = 40;
                    break;
                case EnemyTypes.HORNET:
                    defensePoints = 35;
                    break;
                case EnemyTypes.ZOMBIE:
                    defensePoints = 15;
                    break;
            }

           
        }
        public double getDefensePoints(EnemyTypes type) 
        {
            return defensePoints;
        
        }
        public void setHealth(EnemyTypes type)
        {
            // switch statement goes here
            switch (type)
            {
                case EnemyTypes.BAT:
                    health = 150;
                    break;
                case EnemyTypes.CAVECRAWLER:
                    health = 170;
                    break;
                case EnemyTypes.HORNET:
                   health= 110;
                    break;
                case EnemyTypes.ZOMBIE:
                    health = 100;
                    break;
            }

        }
        public double getHealth(EnemyTypes type) 
        {
            return health;
        }
    }
}