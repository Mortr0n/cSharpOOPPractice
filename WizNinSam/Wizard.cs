namespace WizNinSam
{
    class Wizard : Human
    {
        public Wizard (string name) : base(name, 3, 25, 3, 100){}

        public override int Attack(Human target)
        {
            int dmg = Intelligence * 5;
            target.health -= dmg;
            health += dmg;
            Console.WriteLine($"{Name} attacks {target.Name} dealing {dmg} to them and heals himself for {dmg}");
            return target.Health;
        }

        public int Heal(Human target)
        {
            heal = Intelligence * 10;
            target.Health += heal;
            Console.WriteLine($"{Name} heals {target.Name} for {heal} health");
            return target.Health;
        }
    }
}