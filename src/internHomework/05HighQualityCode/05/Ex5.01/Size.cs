using System;

namespace Ex5._01
{
    public class Size
    {
        private double width;
        private double height;

        public double Width 
        {
            get 
            {
                return this.width;
            }
            set 
            {
                this.width = value;
            }
        }

        public double Height 
        {
            get 
            {
                return this.height;
            }
            set 
            {
                this.height = value;
            }
        }

        public Size(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public static Size GetRotatedSize(Size size, double angleInDegrees)
        {
            double angleInRadians = angleInDegrees * Math.PI / 180;

            double sin = Math.Sin(angleInRadians);
            double cos = Math.Cos(angleInRadians);

            double rotatedWidth = Math.Abs(cos * size.width) + Math.Abs(sin * size.height);
            double rotatedHeight = Math.Abs(sin * size.width) + Math.Abs(cos * size.height);

            return new Size(rotatedWidth, rotatedHeight);
        }
    }
}
