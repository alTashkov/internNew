namespace Ex4._01
{
    public class Call
    {
        private DateTime dateTimeOfCall;

        private string phoneDialed;

        private long callDurationSeconds;
        public DateTime DateTimeOfCall
        {
            get { return dateTimeOfCall; }
            set { dateTimeOfCall = value; }
        }
        public string PhoneDialed
        {
            get { return phoneDialed; }
            set
            {
                phoneDialed = value;
            }
        }
        public long CallDurationSeconds
        {
            get { return callDurationSeconds; }
            set
            {
                callDurationSeconds = value;
            }
        }
        public Call() { }

        public Call(DateTime dateTimeOfCall, string phoneDialed, long callDurationSeconds)
        {
            this.dateTimeOfCall = dateTimeOfCall;
            this.phoneDialed = phoneDialed;
            this.callDurationSeconds = callDurationSeconds;
        }

        public override string ToString()
        {
            return $"Call to {phoneDialed} on {dateTimeOfCall.Day}.{dateTimeOfCall.Month}.{dateTimeOfCall.Year} at {dateTimeOfCall.Hour} o'clock with duration {(callDurationSeconds/60):F2} minutes.";
        }
        public double CalculateCallPrice(double pricePerMinute)
        {
            double calculatedPrice = (this.CallDurationSeconds / 60) * pricePerMinute;
            return calculatedPrice;
        }
    }
}
