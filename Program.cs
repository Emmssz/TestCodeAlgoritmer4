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

            
            linkedListHashTable.Add("ID1", new Student("Hanna", "20", "h22HaSe"));
            linkedListHashTable.Add("ID2", new Student("Gustav", "33", "h55GuEr"));

            
            Console.WriteLine(linkedListHashTable.Get("ID1")); 
            Console.WriteLine(linkedListHashTable.Get("ID2")); 

           
            linkedListHashTable.Remove("ID1");

            try
            {
                
                Console.WriteLine(linkedListHashTable.Get("ID1"));
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine(ex.Message); 
            }

            
            
            
            
            
            // ARRAY
            
            
            Console.WriteLine("\nHashTable using Array:");

            

            IHashTableInterface arrayHashTable = new HashTableArray(10);


            linkedListHashTable.Add("ID1", new Student("Hanna", "20", "h22HaSe"));
            linkedListHashTable.Add("ID2", new Student("Gustav", "33", "h55GuEr"));

            
            Console.WriteLine(arrayHashTable.Get("ID1")); 
            Console.WriteLine(arrayHashTable.Get("ID2")); 


            /
            arrayHashTable.Remove("ID1");

            try
            {
                
                Console.WriteLine(arrayHashTable.Get("ID1"));
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }


              
            
            
            //  LISTA
            
            Console.WriteLine("\nHashTable using List:")


            IHashTableInterface listHashTable = new HashTableList(10);

            
            linkedListHashTable.Add("ID1", new Student("Hanna", "20", "h22HaSe"));
            linkedListHashTable.Add("ID2", new Student("Gustav", "33", "h55GuEr"));


            Console.WriteLine(listHashTable.Get("ID1")); 

            
            listHashTable.Remove("ID1");

            try
            {
                
                Console.WriteLine(listHashTable.Get("ID1"));
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine(ex.Message); 
            }

            Console.ReadLine(); 
        }
    }
}




