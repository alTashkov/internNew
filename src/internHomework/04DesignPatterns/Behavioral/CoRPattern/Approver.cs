namespace CoRPattern
{
    public abstract class Approver
    {
        //handler
        protected Approver next;

        public void SetNext(Approver next)
        {
            this.next = next;
        }

        public abstract void Approve(int amount);
    }
}
