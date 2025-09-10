namespace CommandPattern
{
    //Command lets you add behaviour externally 
    //without modifying the receiver
    //Decouples the invoker from the receiver.
    internal class Program
    {
        static void Main(string[] args)
        {
            Television tv = new Television();

            ICommand onCommand = new TurnOnCommand(tv);
            ICommand offCommand = new TurnOffCommand(tv);

            RemoteControl remote = new RemoteControl();

            remote.SetCommand(onCommand);
            remote.PressButton();

            remote.SetCommand(offCommand);
            remote.PressButton();
        }
    }
}
