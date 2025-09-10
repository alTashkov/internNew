using System;

namespace BridgePattern
{
    public class Radio : IDevice
    {
        public void TurnOff()
        {
            Console.WriteLine("The radio is OFF");
        }

        public void TurnOn()
        {
            Console.WriteLine("The radio is ON");
        }
    }
}
