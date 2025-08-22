using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Ex5._01
{
    class Rectangle : Shape
    {
        public Rectangle(int width, int height)
        {
            Width = width; 
            Height = height;
        }
        public override int CalculateSurface()
        {
            return Width * Height;
        }
    }
}
