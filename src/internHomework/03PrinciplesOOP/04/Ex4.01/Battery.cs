namespace Ex4._01
{
    public class Battery
    {
        private string model;

        private double? hoursIdle;

        private double? hoursTalk;

        private BatteryType batteryType;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public double? HoursIdle
        {
            get { return hoursIdle; }
            set { hoursIdle = value; }
        }

        public double? HoursTalk
        {
            get { return hoursTalk; }
            set { hoursTalk = value; }
        }

        public BatteryType BatteryType
        {
            get { return batteryType; }
            set { batteryType = value; }
        }
    }
}
