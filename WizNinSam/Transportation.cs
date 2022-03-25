namespace WizNinSam
{
    class Transportation : IRideable
    {
        public int NumPassengers;
        public string Color;
        public double MilesTraveled{get;set;}

        public bool Flies;

        public Transportation(int numPass, string color, bool flies)
        {
            NumPassengers = numPass;
            Color = color;
            MilesTraveled = 0;
            Flies = flies;
        }

        public Transportation(bool flies)
        {
            NumPassengers = 1;
            Color = "brown";
            MilesTraveled = 0;
            Flies = flies;
        }

        public void Ride(double distance)
        {
            MilesTraveled += distance;
        }
        
    }
}