using System;

namespace CoRPattern
{
    public class TeamLead : Approver
    {
        //concrete handler
        public override void Approve(int amount)
        {
            if (amount <= 1000)
            {
                Console.WriteLine("TeamLead approved " + amount);
            }
            else if(next != null)
            {
                next.Approve(amount);
            }
        }
    }
}
