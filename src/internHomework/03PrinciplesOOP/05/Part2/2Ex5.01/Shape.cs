using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Ex5._01
{
    public abstract class Shape
    {
        private int width;
        private int height;
        public int Width { 
            get { return width; }
            set 
            {
                if (value < 1)
                {
                    throw new ArgumentException("Width must be a positive number!");
                }
                width = value;
            }
        }

        public int Height
        {
            get { return height; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Height must be a positive number!");
                }
                height = value;
            }
        }

        public abstract int CalculateSurface();
    }
}
