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

    class Food
    {
        public string Name;
        public int Calories;
        public bool IsSpicy;
        public bool IsSweet;

        public Food(string name, int cal, bool spicy, bool sweet)
        {
            Name = name;
            Calories = cal;
            IsSpicy = spicy;
            IsSweet = sweet;
        }
    }

    class Buffet
    {
        public List<Food> Menu;

        public Buffet()
        {
            Menu = new List<Food>();
            {
                Food sushi = new Food("Sushi", 150, true, true);
                Food sashimi = new Food("Sashimi", 130, false, false);
                Food cornDog = new Food("Corn Dog", 280, false, true);
                Food mousse = new Food("Chocolate Mousse", 367, false, true);
                Food taco = new Food("Spicy Taco", 340, true, false);
                Food burger = new Food("Deluxe Hamburger", 480, false, false);
                Food okra = new Food("Fried Okra", 390, false, false);
            }
        }
        Random rand = new Random();
        public Food Serve()
            {
                return Menu[rand.Next(1,7)];
            }
            
    }

    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;

        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>{};
        }

        public bool isFull
        {
            get
            {
                if(calorieIntake > 1200)
                {
                    return true;
                }
                return false;
            }
        }

        public void Eat(Food foodItem)
        {
            if(!isFull)
            {
                
            }
        }
    }
}