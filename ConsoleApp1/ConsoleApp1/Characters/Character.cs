using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Behavior;

namespace ConsoleApp1.Characters
{
    public abstract class Character
    {
        public Fight Ifight;
        public WeaponBehavior Iweaponbehavior;
        public void fight()
        {
            Console.WriteLine("I wont to  kill!!!");
        }
        public abstract void display();
        public void perfomeFight()
        {
            Ifight.fight();
        }
        public void setIweaponBehavior(WeaponBehavior Iweaponbehavior)
        {
            this.Iweaponbehavior = Iweaponbehavior;
        }
        public void peromeWeapon()
        {
            Iweaponbehavior.setWeapon();
        }
    }
}
