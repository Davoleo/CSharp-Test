using System;
using System.Collections.Specialized;
using System.Security.AccessControl;

namespace Console_Test
{

    /// <summary>
    /// Class to store information about a warrior
    /// and capabilities to block and attack
    /// </summary>
    class Warrior
    {
        //Name
        public string Name { get; set; }
        //Health
        public int Health { get; set; }
        //Max Attack
        public int MaxAttack { get; set; }
        //Max Block
        public int MaxBlock { get; set; }

        private Random random;

        public Warrior(string name, int health, int maxAttack, int maxBlock)
        {
            Name = name;
            Health = health;
            MaxAttack = maxAttack;
            MaxBlock = maxBlock;
            random = new Random();
        }

        //Attack
        public int Attack()
        {
            return random.Next(MaxAttack) + 1;
        }

        //Block
        public int Block()
        {
            return random.Next(MaxBlock) + 1;
        }

    }
}
