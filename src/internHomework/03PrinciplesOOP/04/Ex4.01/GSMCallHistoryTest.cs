using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4._01
{
    internal class GSMCallHistoryTest
    {
        static void Main()
        {
            GSM gsm = new GSM();
            Call call1 = new Call(new DateTime(2005, 04, 24), "+359 882 855 688", 501);
            Call call2 = new Call(new DateTime(2025, 04, 02), "+359 722 845 438", 1532);
            Call call3 = new Call(new DateTime(2012, 03, 02), "+359 722 845 438", 104);

            gsm.AddCall(call1);
            gsm.AddCall(call2);
            gsm.AddCall(call3);

            Call longestCall = new Call();

            Console.WriteLine("Call history:");
            Console.WriteLine("-----------------");
            Console.WriteLine();

            for (int i = 0; i < gsm.CallHistory.Count; i++)
            {
                Call call = gsm.CallHistory[i];

                if(call.CallDurationSeconds > longestCall.CallDurationSeconds)
                {
                    longestCall = call;
                }

                Console.WriteLine(call.ToString());
                Console.WriteLine($"Price for call: {call.CalculateCallPrice(0.37)} lv.");
                Console.WriteLine();
            }

            Console.WriteLine("-----------------");
            Console.WriteLine();

            Console.WriteLine("Removing call with duration: " + $"{longestCall.CallDurationSeconds/60:F2} minutes.\nUpdated call history:");
            gsm.DeleteCall(longestCall);
            Console.WriteLine("-----------------");

            gsm.PrintCallHistory();
            Console.WriteLine("-----------------");

            Console.WriteLine("Clearing call history...");
            Console.WriteLine("Call history cleared: ");
            gsm.ClearCalls();
            gsm.PrintCallHistory();

        }
    }
}
