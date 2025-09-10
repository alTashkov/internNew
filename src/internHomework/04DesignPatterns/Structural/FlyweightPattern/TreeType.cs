using System;

namespace FlyweightPattern
{
    public class TreeType : ITreeFlyweight
    {
        private string name;

        private string color;

        private string texture;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Texture
        {
            get { return texture; }
            set { texture = value; }
        }

        public TreeType(string name, string color, string texture)
        {
            this.name = name;
            this.color = color;
            this.texture = texture;
        }

        public void Display(int x, int y)
        {
            Console.WriteLine($"Tree '{Name}' [{Color}, {Texture}] at ({x},{y})");
        }
    }
}
