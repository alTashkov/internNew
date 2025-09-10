namespace _4._02
{
    public struct Point3D
    {
        private double x;

        private double y;

        private double z;

        public double X
        {
            get { return x; }
            private set
            {
                x = value;
            }
        }

        public double Y
        {
            get { return y; }
            private set
            {
                y = value;
            }
        }

        public double Z
        {
            get { return z; }
            private set
            {
                z = value;
            }
        }

        private static readonly Point3D centerPoint = new Point3D(0, 0, 0);
        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public Point3D(string pathInStringFormat)
        {
            List<double> currentPoint = new List<double>();
            for (int i = 0; i < pathInStringFormat.Length; i++)
            {
                if (currentPoint.Count >= 3)
                {
                    break;
                }
                if (!double.TryParse(pathInStringFormat[i].ToString(), out double a))
                {
                    continue;
                }
                currentPoint.Add(a);
            }

            if (currentPoint.Count > 0)
            {
                double x = currentPoint[0];
                double y = currentPoint[1];
                double z = currentPoint[2];

                this.x = x;
                this.y = y;
                this.z = z;
            }

        }
        public override string ToString()
        {
            return $"[{x},{y},{z}]";
        }

        public static Point3D CenterPoint
        {
            get { return centerPoint; }
        }
    }
}
