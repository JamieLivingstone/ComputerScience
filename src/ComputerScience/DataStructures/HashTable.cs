using System.Collections.Generic;

namespace ComputerScience.DataStructures
{
    internal class Entry
    {
        public int Key { get; set; }
        public string Value { get; set; }
    }
    
    public class HashTable
    {
        private readonly LinkedList<Entry>[] _entries = new LinkedList<Entry>[10];
        private int _size = 0;
        
        public void Put(int key, string value)
        {
            var hash = Hash(key);
            var address = _entries[hash];

            if (address == null)
            {
                address = new LinkedList<Entry>();
                _entries[hash] = address;
            }

            var entry = new Entry {Key = key, Value = value};

            address.AddLast(entry);
            
            _size++;
        }

        public string Get(int key)
        {
            var address = _entries[Hash(key)];

            if (address == null)
            {
                return null;
            }

            var match = address.First;

            while (match != null)
            {
                if (match.Value.Key == key)
                {
                    return match.Value.Value;
                }
                
                match = match?.Next;
            }

            return null;
        }

        public string Remove(int key)
        {
            var address = _entries[Hash(key)];

            if (address == null)
            {
                return null;
            }

            var match = address.First;

            while (match != null)
            {
                if (match.Value.Key == key)
                {
                    break;
                }
                
                match = match.Next;
            }

            if (match != null)
            {
                address.Remove(match);
                _size--;
                return match.Value.Value;
            }

            return null;
        }

        private int Hash(int key)
        {
            return key % _entries.Length;
        }

        public int Size() => _size;
    }
}