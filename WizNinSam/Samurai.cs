using System;

namespace WizNinSam
{
    class Samurai : Human
    {
        public Samurai (string name) : base(name, 3, 3, 3, 200){}

        public override int Attack(Human target)
        {
            if(target.Health < 50)
            {
                target.Health -= target.Health;
                Console.WriteLine($"{Name} deals a deathblow to {target.Name};");
                return target.Health;
            }
            int dmg = Strength * 5;
            target.Health -= dmg;
            return target.Health;
            
        }

        public void Meditate()
        {
            Console.WriteLine($"{Name} heals himself back to full health");
            Health = 200;
        }
    }
}