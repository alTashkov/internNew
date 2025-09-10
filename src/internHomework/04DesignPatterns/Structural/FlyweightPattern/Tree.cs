namespace FlyweightPattern
{
    internal class Tree
    {
        private int x;
        private int y;

        private ITreeFlyweight type;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public Tree(int x ,int y, ITreeFlyweight type)
        {
            this.x = x;
            this.y = y;

            this.type = type;
        }

        public void Display()
        {
            type.Display(x, y);
        }
    }
}
