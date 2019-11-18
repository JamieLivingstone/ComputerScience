using System;

namespace ComputerScience.DataStructures
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int value)
        {
            Value = value;
        }
    }

    public class LinkedList
    {
        private Node _head { get; set; }
        private Node _tail { get; set; }
        private int _size { get; set; }

        public void AddFirst(int value)
        {
            var node = new Node(value);

            if (IsEmpty())
            {
                _head = node;
                _tail = node;
            }
            else
            {
                node.Next = _head;
                _head = node;
            }

            _size++;
        }

        public void AddLast(int value)
        {
            var node = new Node(value);

            if (IsEmpty())
            {
                _head = node;
                _tail = node;
            }
            else
            {
                _tail.Next = node;
                _tail = node;
            }

            _size++;
        }

        public void DeleteFirst()
        {
            if (IsEmpty())
            {
                throw new IndexOutOfRangeException();
            }

            if (_head == _tail)
            {
                _head = null;
                _tail = null;
            }
            else
            {
                var second = _head.Next;
                _head.Next = null;
                _head = second;
            }

            _size--;
        }

        public void DeleteLast()
        {
            if (IsEmpty())
            {
                throw new IndexOutOfRangeException();    
            }
            
            var node = _head;

            while (node.Next?.Next != null)
            {
                node = node.Next;
            }

            _tail = node;
            _tail.Next = null;
            _size--;
        }

        public bool Contains(int value)
        {
            return IndexOf(value) != -1;
        }

        public int IndexOf(int value)
        {
            var current = _head;
            var index = 0;

            while (current != null)
            {
                if (current.Value == value)
                {
                    return index;
                }

                current = current.Next;
                index++;
            }

            return -1;
        }

        private bool IsEmpty()
        {
            return _size == 0;
        }

        public int Size() => _size;

        // This should never be on a linked list, if you need to reverse use another data structure such as a doubly linked list, this is purely for academic purposes
        public void Reverse()
        {
            if (IsEmpty())
            {
                return;
            }
            
            Node originalHead = _head;
            Node previous = null;
            Node current = _head;
            Node following = _head;

            while (current != null)
            {
                following = following.Next;
                current.Next = previous;
                previous = current;
                current = following;
            }

            _head = previous;
            _tail = originalHead;
        }
    }
}