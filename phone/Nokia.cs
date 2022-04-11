

namespace Phone
{
    public class Nokia : Phones, IRingable
    {
        private bool unlocked;
        public Nokia(string versionNumber, int batteryPercent, string carrier, string ringTone) : base(versionNumber, batteryPercent, carrier, ringTone)  
        {
            unlocked = false;
        }

        public string Ring()
        { 
            return "Ring Ring";
        }

        public string Unlock()
        {
            unlocked = true;
            return "Your Nokia phone is now unlocked";
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Nokia Version Number: {VersionNumber}");
            Console.WriteLine($"Battery at {BatteryPercent}%");
            Console.WriteLine($"Carrier is {Carrier}");
            Console.WriteLine($"Current RingTone {RingTone}");
        }
    }
    

}