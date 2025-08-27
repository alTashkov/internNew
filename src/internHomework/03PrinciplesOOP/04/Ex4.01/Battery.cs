namespace Ex4._01
{
    public class Battery
    {
        public string Model;
        public double HoursIdle;
        public double HoursTalk;
        public enum BatteryType
        {
            LiIon,
            NiMH,
            NiCd
        }
        public Battery(string model, double hoursIdle, double hoursTalk)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }
    }
}
