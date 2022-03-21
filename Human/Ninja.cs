using System;
using System.Collections.Generic;
namespace Human
{
    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;

        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }

        public bool isFull
        {
            get
            {
                return calorieIntake > 1200;
            }
        }

        public bool Eat(Food foodItem)
        {
            if (!isFull)
            {
                calorieIntake += foodItem.Calories;
                FoodHistory.Add(foodItem);
                Console.WriteLine($"Ninja eats some {foodItem.Name}");
            }
            else
            {
            Console.WriteLine("Ninja is full!");                
            }
            return isFull;
        }
    }
}
