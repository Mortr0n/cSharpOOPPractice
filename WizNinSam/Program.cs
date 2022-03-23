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
        }
    }
}