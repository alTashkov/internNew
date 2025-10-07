using System;

namespace Ex5._01
{
    //to finish
    public class Size
    {
        public double width, height;

        public Size(double width, double height)
        {
            this.width = width;
            this.width = height;
        }

        public static Size GetRotatedSize(
            Size size, 
            double angleOfTheFigureThatWillBeRotated)
        {

            double sinValueOfAngle = Math.Sin(angleOfTheFigureThatWillBeRotated);
            double cosValueOfAngle = Math.Cos(angleOfTheFigureThatWillBeRotated);

            double rotatedWidth = Math.Abs(cosValueOfAngle * size.width);
            double rotatedHeight = Math.Abs(sinValueOfAngle * size.height);

            return new Size(rotatedWidth, rotatedHeight);
        }
    }
}
