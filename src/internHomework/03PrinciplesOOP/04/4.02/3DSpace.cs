using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._02
{
    static class _3DSpace
    {
        public static double CalculateDistanceBetweenTwoPoints(Point3D point1, Point3D point2)
        {
            return (Math.Sqrt((point2.X -  point1.X) * (point2.X - point1.X) + 
                (point2.Y - point1.Y) * (point2.Z - point1.Z)));
        }
    }
}
