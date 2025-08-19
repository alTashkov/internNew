using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._02
{
    class Path3D
    {
        public List<Point3D> points = new List<Point3D>();
        public Path3D() { }
        public Path3D(List<Point3D> Points) 
        {
            points = Points;
        }
        public List<Point3D> Points
        {
            get { return this.points; }
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < this.Points.Count; i++)
            {
                stringBuilder.AppendLine(this.Points[i].ToString());
            }

            string points = stringBuilder.ToString();
            return points;
        }
    }
}
