using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human chris = new Human("Chris");
            Human jiraiya = new Human("Jiraiya", 2, 5, 4, 110);
            chris.Attack(jiraiya);
        }
    }

    class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;

        public int Health
        {
            get { return Health; }
        }

        public Human(string name)
        {
            {
                Name = name;
                Strength = 3;
                Intelligence = 3;
                Dexterity = 3;
                health = 100;
            }
        }

        public Human(string name, int str, int intel, int dex, int hlth)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = hlth;
        }

        public int Attack(Human humanToAttack)
        {
            int damage = Strength * 5;
            humanToAttack.health -= damage;
            Console.WriteLine($"{Name} attacked {humanToAttack.Name} and did {damage} damage.  {humanToAttack.Name} is now at {humanToAttack.health} health! ");
            return humanToAttack.health;
        }

    }
}