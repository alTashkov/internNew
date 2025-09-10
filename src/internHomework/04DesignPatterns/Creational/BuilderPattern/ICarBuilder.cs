namespace BuilderPattern
{
    public interface ICarBuilder
    {
        void SetEngine(string engine);

        void SetWheels(int wheels);

        void SetGPS(string gps);

        void SetSunroof(bool hasSunroof);

        Car Build();
    }
}
