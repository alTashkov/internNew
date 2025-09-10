using System;

namespace BridgePattern
{
    public class TV : IDevice
    {
        public void TurnOff()
        {
            Console.WriteLine("TV is OFF");
        }

        public void TurnOn()
        {
            Console.WriteLine("TV is ON");
        }
    }
}
