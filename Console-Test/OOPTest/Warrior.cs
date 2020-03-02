using System;

namespace Console_Test.OOPTest
{

    /// <summary>
    /// Class to store information about a warrior
    /// and capabilities to block and attack
    /// </summary>
    class Warrior
    {
        //Name
        public string Name { get; }
        //Health
        public int Health { get; set; }
        //Max Attack
        public int MaxAttack { get; }
        //Max Block
        public int MaxBlock { get; }
        //Random Object instance
        private Random random;

        public Warrior(string name = "Warrrior", int health = 100, int maxAttack = 2, int maxBlock = 2)
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
