using System;

namespace BuilderPattern
{
    public class Car
    {
        private string _engine;
        private int _wheels;
        private string _gps;
        private bool _sunroof;

        public string Engine
        {
            get { return _engine; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Engine cannot be empty");
                }
                _engine = value;
            }
        }
        public int Wheels
        {
            get => _wheels;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Wheels must be positive");
                _wheels = value;
            }
        }

        public string GPS
        {
            get => _gps;
            set => _gps = value ?? "No GPS";
        }

        public bool Sunroof
        {
            get => _sunroof;
            set => _sunroof = value;
        }

        public override string ToString()
        {
            return $"Engine: {Engine}, Wheels: {Wheels}, Sunroof: {Sunroof}";
        }
    }
}
