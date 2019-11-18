using System.Collections.Generic;

namespace ComputerScience.DataStructures
{
    public class Stack<T>
    {
        private readonly LinkedList<T> _list = new LinkedList<T>();
        
        public void Push(T value)
        {
            _list.AddFirst(value);
        }

        public T Pop()
        {
            var val = _list.First.Value;
            _list.RemoveFirst();
            return val;
        }

        public T Peek()
        {
            return _list.First.Value;
        }

        public bool IsEmpty()
        {
            return _list.Count == 0;
        }

        public int Size() => _list.Count;
    }
}