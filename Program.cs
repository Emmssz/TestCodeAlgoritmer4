using System;

namespace TestCodeAlgoritmer4
{
    class Program
    {
        static void Main(string[] args)
        {
            // LÄNKAD LISTA
            Console.WriteLine("HashTable using LinkedList:");

            IHashTableInterface linkedListHashTable = new HashTableLinkedList(10);

            linkedListHashTable.Add("student1", new Student("Hanna", "20", "h22HaSe"));
            linkedListHashTable.Add("student2", new Student("Gustav", "33", "h55GuEr"));

            Console.WriteLine(linkedListHashTable.Get("student1"));
            Console.WriteLine(linkedListHashTable.Get("student2"));

            linkedListHashTable.Remove("student1");

            try
            {
                Console.WriteLine(linkedListHashTable.Get("student1"));
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // ARRAY
            Console.WriteLine("\nHashTable using Array:");

            IHashTableInterface arrayHashTable = new HashTableArray(10);

            arrayHashTable.Add("student1", new Student("Hanna", "20", "h22HaSe"));
            arrayHashTable.Add("student2", new Student("Gustav", "33", "h55GuEr"));

            Console.WriteLine(arrayHashTable.Get("student1"));
            Console.WriteLine(arrayHashTable.Get("student2"));

            arrayHashTable.Remove("student1");

            try
            {
                Console.WriteLine(arrayHashTable.Get("student1"));
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // LISTA
            Console.WriteLine("\nHashTable using List:");

            IHashTableInterface listHashTable = new HashTableList(10);

            listHashTable.Add("student1", new Student("Hanna", "20", "h22HaSe"));
            listHashTable.Add("student2", new Student("Gustav", "33", "h55GuEr"));

            Console.WriteLine(listHashTable.Get("student1"));

            listHashTable.Remove("student1");

            try
            {
                Console.WriteLine(listHashTable.Get("student1"));
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}




