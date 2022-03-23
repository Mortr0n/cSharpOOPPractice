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
                target.Health -= target.health;
                Console.WriteLine($"{Name} deals a deathblow to {target.Name};")
                return target.Health;
            }
        }

        public int Meditate()
        {
            health = 200;
        }
    }
}