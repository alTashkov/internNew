namespace CommandPattern
{
    public class TurnOffCommand : ICommand
    {
        private Television _tv;

        public TurnOffCommand(Television tv)
        {
            _tv = tv;
        }

        public void Execute()
        {
            _tv.TurnOff();
        }
    }
}
