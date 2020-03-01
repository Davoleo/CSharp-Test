using System;
using System.Runtime.Serialization.Formatters;

namespace Console_Test
{
    /// <summary>
    /// Manages the battle between two warriors 
    /// </summary>
    class Battle
    {
        public static void StartFight(Warrior w1, Warrior w2)
        {
            while (w1.Health > 0 && w2.Health > 0)
            {
                GenAttackResult(w1, w2);
                GenAttackResult(w2, w1);
            }
        }

        private static void GenAttackResult(Warrior warriorA, Warrior warriorB)
        {
            int attack = warriorA.Attack();
            int block = warriorB.Block();

            int diff = attack - block;

            if (diff > 0)
            {
                warriorB.Health -= diff;
            }

            Console.WriteLine(warriorA.Name + " Attacked with a value of " + attack);
            Console.WriteLine(warriorB.Name + " Blocked an attack value of " + block);
            Console.WriteLine(warriorB.Name + "'s Health dropped of " + diff + " and currently is " + warriorB.Health);
            
            if (warriorB.Health <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(warriorA.Name + " has won the battle with " + warriorA.Health + " remaining health!");
            }
        }
    }
}
