using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4._01
{
    internal class Call
    {
        private DateTime dateTimeOfCall;
        private string phoneDialed;
        private long callDurationSeconds;
        public DateTime DateTimeOfCall
        {
            get { return this.DateTimeOfCall; }
            set { this.DateTimeOfCall = value; }
        }
        public string PhoneDialed
        {
            get { return this.phoneDialed; }
            set
            {
                this.phoneDialed = value;
            }
        }
        public long CallDurationSeconds
        {
            get { return this.callDurationSeconds; }
            set
            {
                this.callDurationSeconds = value;
            }
        }

        public Call() { }

        public Call(DateTime dateTimeOfCall, string phoneDialed, long callDuration)
        {
            this.dateTimeOfCall = dateTimeOfCall;
            this.phoneDialed = phoneDialed;
            this.callDurationSeconds = callDuration;
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
