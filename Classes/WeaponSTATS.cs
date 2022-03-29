using System;
using MazeEscape.Enums;
namespace MazeEscape
{
    public class WeaponSTATS
    {
        public double damage { get; set; }
        //setters
        public virtual double setDamage(WeaponsEnum Weapon)
        {
            //double damage = 0;
            if (Weapon == WeaponsEnum.BOW) 
            {
                damage = 35;
            }
            else if (Weapon == WeaponsEnum.SHORTSWORD)
            {
                damage = 40;
            }
            else if (Weapon == WeaponsEnum.SPEAR)
            {
                damage = 45;
            }
            else if (Weapon == WeaponsEnum.FISTS)
            {
                damage = 10;
            }

            return damage;

    }
     
    }

}
