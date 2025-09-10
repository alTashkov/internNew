using System;

namespace MediatorPattern
{
    public class ChatUser : User
    {
        public ChatUser(IChatMediator chatMediator, string name) : base(chatMediator, name)
        {
        }

        public override void Receive(string message)
        {
            Console.WriteLine($"{Name} received a message: {message}");
        }

        public override void Send(string message, User receiver)
        {
            Console.WriteLine($"{Name} enter a message you want to send: ");
            if (string.IsNullOrEmpty(message))
            {
                message = Console.ReadLine();
            }
            chatMediator.SendMessage(message,receiver);
        }
    }
}
