using System;

namespace CoRPattern
{
    internal class Director : Approver
    {
        public override void Approve(int amount)
        {
            Console.WriteLine("Director approved " + amount);
        }
    }
}
