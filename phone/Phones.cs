using System.Collections.Generic;

namespace Phone
{
    public abstract class Phones
    {
        private string _versionNumber;
        private int _batteryPercentage;
        private string _carrier;
        private string _ringTone;

        public Phones(string versionNumber, int batteryPercent, string carrier, string ringTone)
        {
            _versionNumber = versionNumber;
            _batteryPercentage = batteryPercent;
            _carrier = carrier;
            _ringTone = ringTone;
        }

        public abstract void DisplayInfo();

        public string VersionNumber { get { return _versionNumber; }}
        public int BatteryPercent { get { return _batteryPercentage; }}
        public string Carrier { get { return _carrier; }}
        public string RingTone { get { return _ringTone; }}
    }
}