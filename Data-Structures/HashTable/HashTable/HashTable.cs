using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using LinkedListLibrary;

namespace HashTable
{
    public class HashTable<T>
    {
        public LinkedList<LinkedListNode<Node<T>>>[] Map { get; set; }
        public HashTable(int size)
        {
            Map = new LinkedList<LinkedListNode<Node<T>>>[size];
        }


        /// <summary>
        /// Computes a hashed integer for a given key
        /// </summary>
        /// <param name="key">Key to be hashed</param>
        /// <returns>Hashed index location</returns>
        public int GetHash(string key)
        {
            int total = 0;
            for (int i = 0; i < key.Length; i++)
            {
                total += key[i];
            }

            int primeValue = total * 599;
            int index = primeValue % Map.Length;

            return index;
        }

        /// <summary>
        /// Add a key value pair to a hash table.
        /// </summary>
        /// <param name="key">Key for creating hash index</param>
        /// <param name="value">Value to be stored</param>
        public void Add(string key, T value)
        {
            int index = GetHash(key);
            Node<T> htNode = new Node<T>(value, key);
            LinkedListNode<Node<T>> node = new LinkedListNode<Node<T>>(htNode);

            if (Map[index] is null)
            {
                // instantiate a new linked list
                Map[index] = new LinkedList<LinkedListNode<Node<T>>>();

            }

            Map[index].AddLast(node);

        }

        /// <summary>
        /// Get a specific entry in the hash table by key
        /// </summary>
        /// <param name="key">Key to be retrieved from table</param>
        /// <returns>Node T corresponding to the location from the key</returns>
        public T Get(string key)
        {
            int index = GetHash(key);
            if (!(Map[index] is null))
            {
                if (Map[index].Count == 1)
                {
                    var first = Map[index].First;
                    return first.Value.Value.Value;
                }
                else
                {
                    var current = Map[index].First;
                    while (current != null)
                    {
                        if (current.Value.Value.Key == key)
                        {
                            return current.Value.Value.Value;
                        }
                        current = current.Next;
                    }
                }
            }
            return default;
        }

        /// <summary>
        /// Check if a hash table contains a key
        /// </summary>
        /// <param name="key">Key to be searched for</param>
        /// <returns>Boolean representing if the key was found</returns>
        public bool Contains(string key)
        {
            int index = GetHash(key);

            var location = Map[index];

            if (!(location is null))
            {
                var current = Map[index].First;

                while (current != null)
                {
                    if (current.Value.Value.Key == key)
                    {
                        return true;
                    }

                }
            }
            return false;
        }        
    }
}
