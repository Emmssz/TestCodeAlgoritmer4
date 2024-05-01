using System;

namespace TestCodeAlgoritmer4
{
    public interface IHashTableInterface
    {
        void Add(string key, object value);

        object Get(string key);

        bool Remove(string key);
    }
}

