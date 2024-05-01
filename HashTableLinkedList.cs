using System;
using System.Collections.Generic;

namespace TestCodeAlgoritmer4
{
    internal class HashTableLinkedList : IHashTableInterface
    {
        private LinkedList<KeyValuePair<string, object>>[] _buckets;
        private int _capacity;
        private int _count;

        public HashTableLinkedList(int capacity)
        {
            _capacity = capacity;
            _count = 0;
            _buckets = new LinkedList<KeyValuePair<string, object>>[capacity];
        }

        public void Add(string key, object value)
        {
            int hash = HashFunction(key);

            if (_buckets[hash] == null)
            {
                _buckets[hash] = new LinkedList<KeyValuePair<string, object>>();
            }

            foreach (KeyValuePair<string, object> item in _buckets[hash])
            {
                if (item.Key == key)
                {
                    throw new ArgumentException("An element with the same key already exists in the hashtable.");
                }
            }

            _buckets[hash].AddLast(new KeyValuePair<string, object>(key, value));
            _count++;
        }

        public object Get(string key)
        {
            int hash = HashFunction(key);

            if (_buckets[hash] != null)
            {
                foreach (KeyValuePair<string, object> item in _buckets[hash])
                {
                    if (item.Key == key)
                    {
                        return item.Value;
                    }
                }
            }

            throw new KeyNotFoundException("No such key in hashtable");
        }

        public bool Remove(string key)
        {
            int hash = HashFunction(key);

            if (_buckets[hash] != null)
            {
                LinkedListNode<KeyValuePair<string, object>> node = _buckets[hash].First;

                while (node != null)
                {
                    if (node.Value.Key == key)
                    {
                        _buckets[hash].Remove(node);
                        _count--;
                        return true;
                    }
                    node = node.Next;
                }
            }
            return false;
        }

        private int HashFunction(string key)
        {
            
            int hash = 0;
            foreach (char c in key)
            {
                hash += (int)c;
            }
            return hash % _capacity;
        }
    }
}

