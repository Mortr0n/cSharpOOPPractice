namespace WizNinSam
{
    class Program
    {
        static void Main(string[] args)
        {
            Ninja jiraiya = new Ninja("Jiraiya");
            Samurai sasuke = new Samurai("Sasuke");
            Wizard gandalf = new Wizard("Gandalf");
            Human killMe = new Human("GuytoKill");

            jiraiya.Attack(sasuke);
            sasuke.Meditate();
            
            gandalf.Attack(jiraiya);
            killMe.Attack(gandalf);
            // gandalf.Heal(gandalf);
            jiraiya.Steal(gandalf);
            jiraiya.Steal(gandalf);
            jiraiya.Steal(gandalf);
            jiraiya.Steal(gandalf);

            Transportation[] variousTransportationCreatures = new Transportation[]
            {
                new Horse("Nyeeeh", 45, 2, "black", false),
                new GiantWolf(1, "gray", false, "Shadow", 34),
                new Horse("Pegasus", 78, 1, "White", true),
                new GiantWolf(1, "black", false, "Death Eater", 39),
                new GiantWolf(1, "white", true, "Flying Monster", 67),

            };

            foreach(var rideable in variousTransportationCreatures)
            {
                rideable.Ride(100);
                Console.WriteLine("1 Run");
            }
        }
    }
}