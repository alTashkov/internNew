namespace BridgePattern
{
    internal class Program
    {
        //Decouples and abstraction from its implementation
        //Used when you have multiple abstractions and multiple
        //implementations
        static void Main(string[] args)
        {
            IDevice tv = new TV();

            RemoteControl remote = new AdvancedRemote(tv);

            remote.TurnOn();

            ((AdvancedRemote)remote).SetChannel(5);

            IDevice radio = new Radio();

            RemoteControl radioRemote = new AdvancedRemote(radio);

            radioRemote.TurnOn();
        }
    }
}
