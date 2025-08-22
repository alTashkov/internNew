using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2Ex5._01
{
    class Square : Shape
    {
        public Square(int width)
        {
            Width = width;
            Height = width;
        }
        public override int CalculateSurface()
        {
            return Height * Width;
        }
    }
}
