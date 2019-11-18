using System;

namespace ComputerScience.DataStructures
{
    public class ArrayList<T>
    {
        private T[] _list;
        private int _count;

        public ArrayList(int initialCapacity = 10)
        {
            _list = new T[initialCapacity];
        }

        public void Add(T value)
        {
            if (_count >= _list.Length)
            {
                IncreaseCapacity();
            }

            _list[_count] = value;

            _count++;
        }

        public void Remove(int index)
        {
            if (index < 0 || index - 1 > _count)
            {
                throw new ArgumentOutOfRangeException();
            }

            var updatedArray = new T[_list.Length];
            var updatedLastElementIndex = 0;

            for (var i = 0; i < _list.Length; i++)
            {
                if (i != index)
                {
                    updatedArray[updatedLastElementIndex] = _list[i];
                    updatedLastElementIndex++;
                }
            }

            _list = updatedArray;
            _count--;
        }
        
        private void IncreaseCapacity()
        {
            var updatedArray = new T[_list.Length * 2];

            for (var i = 0; i < _list.Length; i++)
            {
                updatedArray[i] = _list[i];
            }

            _list = updatedArray;
        }
        
        public T this[int i] => _list[i];

        public int Count() => _count;
    }
}