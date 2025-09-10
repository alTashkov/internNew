using System;

namespace CoRPattern
{
    public class Manager : Approver
    {
        //concrete handler
        public override void Approve(int amount)
        {
            if (amount <= 1000)
            {
                Console.WriteLine("Manager approved " + amount);
            }
            else if (next != null)
            {
                next.Approve(amount);
            }
        }
    }
}
