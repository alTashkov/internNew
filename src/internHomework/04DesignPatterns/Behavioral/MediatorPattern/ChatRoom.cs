using System.Collections.Generic;

namespace MediatorPattern
{//mediator
    public class ChatRoom : IChatMediator
    {
        private List<User> users  = new List<User>();

        public void RegisterUser(User user)
        {
            users.Add(user);
        }

        public void SendMessage(string message, User receiver)
        {
           receiver.Receive(message);
        }
    }
}
