namespace CommandPattern
{
    public class TurnOnCommand : ICommand
    {
        private Television _tv;
        public TurnOnCommand(Television tv)
        {
            _tv = tv;
        }
        public void Execute()
        {
            _tv.TurnOn();
        }
    }
}
