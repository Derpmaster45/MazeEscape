using System;
namespace MazeEscape
{
    public class WeaponSTATS
    {
        public double damage { get; set; }
        public virtual double setDamage(WeaponsEnum Weapon)
        {
            //double damage = 0;
            if (Weapon == WeaponsEnum.BOW) 
            {
                damage = 25;
            }
            else if (Weapon == WeaponsEnum.SHORTSWORD)
            {
                damage = 20;
            }
            else if (Weapon == WeaponsEnum.Spear)
            {
                damage = 50;
            }

            return damage;
        }
    }

}
