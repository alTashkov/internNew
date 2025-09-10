namespace BuilderPattern
{
    public class CarBuilder : ICarBuilder
    {
        private Car _car = new Car();

        public Car Build()
        {
            return _car;
        }

        public void SetEngine(string engine)
        {
            _car.Engine = engine;
        }

        public void SetGPS(string gps)
        {
            _car.GPS = gps;
        }

        public void SetSunroof(bool hasSunroof)
        {
            _car.Sunroof = hasSunroof;
        }

        public void SetWheels(int wheels)
        {
            _car.Wheels = wheels;
        }
    }
}
