
namespace Human
{
    class SpiceHound : Ninja
    {
        public override bool IsFull
        {
            get { return calorieIntake > 1200; }
        }

        public override void Consume(IConsumable item)
        {
            if(IsFull)
            {
                Console.WriteLine("I can not eat another bite!");
            }
            int newCalories = (item.IsSpicy) ? item.Calories - 5 : item.Calories;
            calorieIntake += newCalories;
            ConsumptionHistory.Add(item);
            item.GetInfo();
        }
    }
}