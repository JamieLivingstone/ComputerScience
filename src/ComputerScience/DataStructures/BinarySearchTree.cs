namespace ComputerScience.DataStructures.BinarySearchTree
{
    public class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
    }
    
    public class BinarySearchTree
    {
        private Node _root;
        
        public void Insert(int value)
        {
            var node = new Node { Value = value };
            
            if (_root == null)
            {
                _root = node;
                return;
            }

            var current = _root;
            
            while (true)
            {
                if (value < current.Value)
                {
                    if (current.Left == null)
                    {
                        current.Left = node;
                        break;
                    }

                    current = current.Left;
                }
                else
                {
                    if (current.Right == null)
                    {
                        current.Right = node;
                        break;
                    }

                    current = current.Right;
                }
            }
        }

        public bool Find(int value)
        {
            var current = _root;

            while (current != null)
            {
                if (value == current.Value)
                {
                    return true;
                }

                current = value < current.Value ? current.Left : current.Right;
            }

            return false;
        }

        public Node GetRoot()
        {
            return _root;
        }
    }
}