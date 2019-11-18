using System.Collections.Generic;

namespace ComputerScience.DataStructures
{
    public class Queue<T>
    {
        private readonly LinkedList<T> _list = new LinkedList<T>();

        public void Enqueue(T value)
        {
            _list.AddLast(value);
        }

        public T Dequeue()
        {
            var value = _list.First.Value;
            
            _list.RemoveFirst();

            return value;
        }

        public T Peek()
        {
            return _list.First.Value;
        }

        public bool IsEmpty()
        {
            return _list.Count == 0;
        }
    }
}