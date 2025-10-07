namespace MediatorPattern
{
    internal class Program
    {
        //Encapsulates communication between objects.
        //It helps for loose coupling.
        //It provides a middleman to the communication
        //between two objects.
        static void Main(string[] args)
        {
            IChatMediator chat = new ChatRoom();

            User johnDoe = new ChatUser(chat,"JohnDoe");
            User ivana = new ChatUser(chat, "Ivana");

            string messageToSend = "";

            ivana.Send(messageToSend, johnDoe);
        }
    }
}
