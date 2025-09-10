namespace FactoryPattern.Factory
{
    public abstract class Logistics
    {
        public abstract ITransport CreateTransport();

        public void PlanDelivery()
        {
            ITransport transport = CreateTransport();
            transport.Deliver();
        }
    }
}
