namespace _2Ex6._01
{
    class Node
    {
        private Node leftNode;
        
        private Node rightNode;

        private int data;

        public Node LeftNode
        {
            get { return leftNode; }
            set { leftNode = value; }
        }
        public Node RightNode
        {
            get { return rightNode; }
            set { rightNode = value; }
        }

        public int Data
        {
            get { return data; }
            set { data = value; }
        }

        public Node(int x)
        {
            data = x;
        }
    }
}
