using System;

namespace WizNinSam
{
    class Ninja : Human
    {
        public Ninja (string name) : base(name, 3, 3, 175, 100) { }

        public override int Attack(Human target)
        {
            int dmg = Dexterity * 5;
            Random rand = new Random();
            if(rand.Next(1,5)<=1)
            {
                dmg += 10;
                Console.WriteLine("Critical HIT!");
            }
            target.health -= dmg;
            Console.WriteLine($"{Name} attacks {target.Name} dealing {dmg} points of damage");
        }

        public int Steal(Human target)
        {
            target.health -= 5;
            health += 5;
            Console.WriteLine($"Sneaky, sneaky Ninja.  Ninjas Health is now {health}. {target.name} is now at {target.health}")
        }
    }
}