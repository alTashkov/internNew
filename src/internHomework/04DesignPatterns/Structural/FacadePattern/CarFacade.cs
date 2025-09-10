namespace FacadePattern
{
    public class CarFacade
    {
        private Engine _engine;
        private Wheels _wheels;
        private GPS _gps;

        public CarFacade()
        {
            _engine = new Engine();
            _wheels = new Wheels();
            _gps = new GPS();
        }

        public void StartCar()
        {
            _engine.Start();
            _wheels.Rotate();
            _gps.Activate();
        }
    }
}
