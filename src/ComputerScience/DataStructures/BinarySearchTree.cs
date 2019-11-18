using System.Collections.Generic;

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

        public IEnumerable<int> TraversePreOrder()
        {
            return TraversePreOrder(_root);
        }

        public IEnumerable<int> TraverseInOrder()
        {
            return TraverseInOrder(_root);
        }
        
        public IEnumerable<int> TraversePostOrder()
        {
            return TraversePostOrder(_root);
        }
        
        private static IEnumerable<int> TraversePreOrder(Node node)
        {
            var result = new List<int>();

            if (node == null)
            {
                return result;
            }
            
            result.Add(node.Value);

            if (node.Left != null)
            {
                result.AddRange(TraversePreOrder(node.Left));
            }

            if (node.Right != null)
            {
                result.AddRange(TraversePreOrder(node.Right));
            }
            
            return result;
        }

        private static IEnumerable<int> TraverseInOrder(Node node)
        {
            var result = new List<int>();

            if (node == null)
            {
                return result;
            }

            if (node.Left != null)
            {
                result.AddRange(TraverseInOrder(node.Left));
            }
            
            result.Add(node.Value);

            if (node.Right != null)
            {
                result.AddRange(TraverseInOrder(node.Right));
            }

            return result;
        }

        private static IEnumerable<int> TraversePostOrder(Node node)
        {
            var result = new List<int>();

            if (node == null)
            {
                return result;
            }

            if (node.Left != null)
            {
                result.AddRange(TraversePostOrder(node.Left));
            }

            if (node.Right != null)
            {
                result.AddRange(TraversePostOrder(node.Right));
            }

            result.Add(node.Value);
            
            return result;
        }
    }
}