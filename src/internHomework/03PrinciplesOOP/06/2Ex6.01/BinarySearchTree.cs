namespace _2Ex6._01
{
    class BinarySearchTree : ICloneable
    {
        private Node root;

        public Node Root
        {
            get { return root; }
            set { root = value; }
        }
        public void AddElement(int el)
        {
            if (root == null) root = new Node(el);
            else AddElement(Root, el);
        }

        public void AddElement(Node root, int el)
        {
            if (el < root.Data)
            {
                if (root.LeftNode == null)
                {
                    root.LeftNode = new Node(el);
                }
                else
                {
                    AddElement(root.LeftNode, el);
                }
            }
            else if (el > root.Data)
            {
                if(root.RightNode == null) root.RightNode = new Node(el);
                else AddElement(root.RightNode, el);
            }
        }

        public Node Search(int el)
        {
            if (root == null)
            {
                return null;
            }
            else return Search(root,el);
        }

        public Node Search(Node root, int el)
        {
            if (el == root.Data)
            {
                return root;
            }
            else if(el < root.Data)
            {
                if (root.LeftNode == null)
                {
                    return null;
                }
                else return Search(root.LeftNode, el);
            }
            else
            {
                if (root.RightNode == null) return null;
                else return Search(root.RightNode, el);
            }
        }

        public void Delete(int el)
        {
            root = Delete(root, el);
        }

        public Node Delete(Node root, int el)
        {
            if (root == null)
            {
                return null;
            }
            if (el < root.Data)
            {
                root.LeftNode = Delete(root.LeftNode,el);
            }
            else if (el > root.Data) root.RightNode = Delete(root.RightNode,el);
            else
            {
                if(root.LeftNode == null && root.RightNode == null)
                {
                    root = null;
                }
                else if(root.LeftNode == null)
                {
                    root = root.RightNode;
                }
                else if(root.RightNode == null)
                {
                    root = root.LeftNode;
                }
                else
                {
                    root.Data = FindMin(root.RightNode);

                    root.RightNode = Delete(root.RightNode,FindMin(root.RightNode));
                }
            }
            return root;
        }

        public int FindMin(Node root)
        {
            if (root == null)
            {
                return -1;
            }
            else if(root.LeftNode == null)
            {
                return root.Data;
            }
            else
            {
                return FindMin(root.LeftNode);
            }
        }

        public object Clone()
        {
            BinarySearchTree clone = new BinarySearchTree();
            clone.root = CloneNode(root);
            return clone;
        }

        private Node CloneNode(Node root)
        {
            if (root == null) return null;

            Node newNode = new Node(root.Data);

            newNode.LeftNode = CloneNode(root.LeftNode);
            newNode.RightNode = CloneNode(root.RightNode);

            return newNode;
        }

        public override string ToString()
        {
            List<int> elements = new List<int>();

            void Traverse(Node node)
            {
                if (node == null) return;

                Traverse(node.LeftNode);

                elements.Add(node.Data);

                Traverse(node.RightNode);
            }

            Traverse(root);

            return string.Join(", ", elements);
        }

        public override bool Equals(object obj)
        {
            if (obj is BinarySearchTree other)
                return AreEqual(root, other.root);

            return false;
        }

        private bool AreEqual(Node n1, Node n2)
        {
            if (n1 == null && n2 == null) return true;
            if (n1 == null || n2 == null) return false;
            return n1.Data == n2.Data &&
                   AreEqual(n1.LeftNode, n2.LeftNode) &&
                   AreEqual(n1.RightNode, n2.RightNode);
        }

        public override int GetHashCode()
        {
            return root?.GetHashCode() ?? 0;
        }

        public static bool operator ==(BinarySearchTree b1, BinarySearchTree b2)
        {
            if (ReferenceEquals(b1, b2)) return true;
            if (b1 is null || b2 is null ) return false;

            return b1.Equals(b2);
        }

        public static bool operator !=(BinarySearchTree b1, BinarySearchTree b2)
        {
            return !(b1 == b2);
        }
    }
}
