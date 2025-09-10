using System;

namespace BridgePattern
{
    public class AdvancedRemote : RemoteControl
    {
        public AdvancedRemote(IDevice device) : base(device){}

        public override void TurnOff()
        {
            device.TurnOff();
        }

        public override void TurnOn()
        {
            device.TurnOn();
        }

        public void SetChannel(int channel)
        {
            Console.WriteLine("Channel set to " + channel);
        }
    }
}
