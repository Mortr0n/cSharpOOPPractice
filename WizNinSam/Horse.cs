namespace WizNinSam
{
    class Horse : Transportation, IRideable
    {
        public string NoiseMade;
        public double Endurance;


        public Horse(string noiseMade, double endurance, int numPass, string color, bool flies) : base(numPass, color, flies)
        {
            NoiseMade = noiseMade;
            Endurance = endurance;
            MilesTraveled = 0;
            Flies = flies;
            Color = color;
        } 


        public new void Ride(double distance)
        {
            if(distance>=Endurance)
            {
                distance = Endurance;
            }
            Console.WriteLine(NoiseMade);
            Console.WriteLine("Hello");
            MilesTraveled  += distance;
        }  

    }
}