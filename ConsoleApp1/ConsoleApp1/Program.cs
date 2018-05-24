using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Behavior;
using ConsoleApp1.Characters;
 
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Character> characters = new List<Character>();
            characters.AddRange(new Character[]
            {
                new King(),
            new Queen(),
            new Troll(),
            new Knight()

            });
            foreach(var character in characters)
            {
                character.display();
                character.fight();
                character.perfomeFight();
                character.peromeWeapon();
                Console.WriteLine("========");
            }

         
        }
    }
}
