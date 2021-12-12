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
            return name;
        }
        public double setAttackPoints(EnemyTypes type)
        {
            //switch statements go before return
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
            return health;
        }
    }
}

