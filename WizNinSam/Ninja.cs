using System;

namespace WizNinSam
{
    class Ninja : Human
    {
        public Ninja (string name) : base(name, 3, 3, 7, 100) { }

        public override int Attack(Human target)
        {
            int dmg = Dexterity * 5;
            Random rand = new Random();
            if(rand.Next(1,5)<=1)
            {
                dmg += 10;
                Console.WriteLine("Critical HIT!");
            }
            target.Health -= dmg;
            Console.WriteLine($"{Name} attacks {target.Name} dealing {dmg} points of damage");
            return target.Health;
        }

        public int Steal(Human target)
        {
            target.Health -= 5;
            Health += 5;
            Console.WriteLine($"Sneaky, sneaky Ninja.  Ninjas Health is now {Health}. {target.Name} is now at {target.Health}");
            return target.Health;
        }
    }
}