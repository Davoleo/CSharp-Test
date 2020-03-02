using System;

namespace Console_Test.OOPTest
{
    /// <summary>
    /// Utility Class:
    /// Manages the battle between two warriors 
    /// </summary>
    class Battle
    {
        /// <summary>
        /// Starts the fighting loop between the warriors
        /// </summary>
        /// <param name="w1">the first warrior</param>
        /// <param name="w2">the second warrior</param>
        public static void StartFight(Warrior w1, Warrior w2)
        {
            while (w1.Health > 0 && w2.Health > 0)
            {
                //The attack of the first warrior while the second warrior blocks
                FightRound(w1, w2);

                //Denies Attack for warrior 2 if he's already dead
                if (w2.Health <= 0)
                    break;

                //The attack of the second warrior while the first blocks
                FightRound(w2, w1);
            }
        }

        /// <summary>
        /// All the actions of the Warriors during a fight round
        /// </summary>
        /// <param name="warriorA">The Attacking warrior</param>
        /// <param name="warriorB">The Defending warrior</param>
        private static void FightRound(Warrior warriorA, Warrior warriorB)
        {
            //Get the random attack and block values for the blocking and the attacking warrior
            int attack = warriorA.Attack();
            int block = warriorB.Block();

            //Get the remaining attack after subtracting the amount of blocked damage
            int diff = attack - block;

            //if the remaining attack damage is higher than 0, we remove it from the blocking warrior's health
            if (diff > 0)
            {
                warriorB.Health -= diff;
            }

            //Print info about this round
            Console.WriteLine(warriorA.Name + " Attacked with a value of " + attack);
            Console.WriteLine(warriorB.Name + " Blocked with a block value of " + block);
            Console.WriteLine(warriorB.Name + "'s Health dropped of " + diff + " and currently is " + warriorB.Health);
            
            //if the blocking warrior is K.O. we print out info about the finished battle
            if (warriorB.Health <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(warriorA.Name + " has won the battle with " + warriorA.Health + " remaining health!");
            }
        }
    }
}
