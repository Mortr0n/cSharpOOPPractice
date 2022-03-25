namespace WizNinSam
{
    class GiantWolf : Transportation, IRideable
    {
        public string Name;
        public double Endurance;
        public string Howl;

        public GiantWolf(int numPass, string color, bool flies, string name, double endurance) : base(numPass, color, flies)
        {
            NumPassengers = numPass;
            Color = color;
            MilesTraveled = 0;
            Flies = flies;
            Name = name;
            Endurance = endurance;
            Howl = "OWWWHWHWHWHWOOOOO!!!";
        }

        public new void Ride(double distance)
        {
            if(distance >= Endurance)
            {
                distance = Endurance;
                Console.WriteLine(Howl);
            }
            MilesTraveled += distance;
        }

    }
}