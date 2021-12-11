using System;
namespace MazeEscape
{
    public class WeaponStats
    {
        public WeaponStats()
        {
            string name;
            double damage;
        }

        // getters and setters
        public double setDamageAmount(WeaponsEnum type)
        {
            int Amount = 0;
            // if statement to see what the weapon type is.
            if (type == WeaponsEnum.BOW)
            {
                Amount = 15;
            }
            else if (type == WeaponsEnum.SHORTSWORD)
            {
                Amount = 10;
            }
            else if (type == WeaponsEnum.Spear)
            {
                Amount = 20;
            }
            return Amount;

        }

    }
}
