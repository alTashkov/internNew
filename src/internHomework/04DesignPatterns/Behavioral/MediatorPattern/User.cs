namespace MediatorPattern
{
    public abstract class User
    {
        protected IChatMediator chatMediator;
        public string Name {get; set; }

        public User (IChatMediator chatMediator, string name)
        {
            this.chatMediator = chatMediator;
            Name = name;
        }

        public abstract void Send(string message, User receiver);

        public abstract void Receive(string message);
    }
}
