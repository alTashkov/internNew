using System.Text;

namespace _4._02
{
    class Path3D
    {
        private List<Point3D> points = [];

        public List<Point3D> Points
        {
            get { return points; }
            set { points = value; }
        }

        public Path3D() { }

        public Path3D(List<Point3D> Points) 
        {
            points = Points;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < Points.Count; i++)
            {
                stringBuilder.AppendLine(Points[i].ToString());
            }

            string points = stringBuilder.ToString();
            return points;
        }
    }
}
