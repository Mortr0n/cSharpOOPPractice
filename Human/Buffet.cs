namespace Human
{   
    class Buffet
    {
        public List<Food> Menu;

        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Sushi", 150, true, true),
                new Food("Sashimi", 130, false, false),
                new Food("Corn Dog", 280, false, true),
                new Food("Chocolate Mousse", 367, false, true),
                new Food("Spicy Taco", 340, true, false),
                new Food("Deluxe Hamburger", 480, false, false),
                new Food("Fried Okra", 390, false, false),
            };
        }
        
        public Food Serve()
            {
                Random rand = new Random();
                return Menu[rand.Next(Menu.Count)];
            }
            
    }
    
}