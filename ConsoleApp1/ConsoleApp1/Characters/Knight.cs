using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Behavior;

namespace ConsoleApp1.Characters
{
    public class Knight : Character
    {
        public override void display()
        {
            Console.WriteLine("Im a Knight!");
        }
        public Knight()
        {
            Iweaponbehavior = new FightwithWeapon();
            Ifight = new Fight();
        }
    }
}
