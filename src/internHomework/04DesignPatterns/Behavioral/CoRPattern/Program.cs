namespace CoRPattern
{
    //client
    //Chain of Responsibility passes a request through a sequence of 
    //handlers until one handles it
    //This decouples the sender from the receiver
    internal class Program
    {
        static void Main(string[] args)
        {
            Approver teamLead = new TeamLead();
            Approver manager = new Manager();
            Approver director = new Director();

            teamLead.SetNext(manager);
            manager.SetNext(director);

            teamLead.Approve(500); 
            teamLead.Approve(3000);
            teamLead.Approve(10000);
        }
    }
}
