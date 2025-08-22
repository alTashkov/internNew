using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Ex5._01
{
    class Triangle : Shape
    {
        public Triangle(int width, int height)
        {
            Height = height;
            Width = width;
        }
        public override int CalculateSurface()
        {
            return (Height * Width) / 2;
        }
    }
}
