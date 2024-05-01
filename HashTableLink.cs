using System;
using System.Collections.Generic;

namespace TestCodeAlgoritmer4
{
    internal class HashTableList : IHashTableInterface
    {
        private List<KeyValuePair<string, object>> _bucket;
        private int _capacity;

        public HashTableList(int capacity)
        {
            _capacity = capacity;
            _bucket = new List<KeyValuePair<string, object>>();
        }

        public void Add(string key, object value)
        {
            int hash = HashFunction(key);

            foreach (KeyValuePair<string, object> item in _bucket)
            {
                if (item.Key == key)
                {
                    throw new ArgumentException("An element with the same key already exists in the hashtable.");
                }
            }

            _bucket.Add(new KeyValuePair<string, object>(key, value));
        }

        public object Get(string key)
        {
            foreach (KeyValuePair<string, object> item in _bucket)
            {
                if (item.Key == key)
                {
                    return item.Value;
                }
            }

            throw new KeyNotFoundException("No such key in hashtable");
        }

        public bool Remove(string key)
        {
            foreach (KeyValuePair<string, object> item in _bucket)
            {
                if (item.Key == key)
                {
                    _bucket.Remove(item);
                    return true;
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

