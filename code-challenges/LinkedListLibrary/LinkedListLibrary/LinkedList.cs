using System;
using System.Text;

namespace LinkedListLibrary
{
    public class LinkedList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }

        public LinkedList()
        {
            Head = null;
            Current = Head;
        }

        /// <summary>
        /// Adds new node to the front of the list
        /// O(1) time efficiency
        /// </summary>
        /// <param name="val">Value to be stored in the node</param>
        public void Insert(int val)
        {
            Current = Head;
            Node node = new Node(val);
            node.Next = Head;
            Head = node;
        }

        /// <summary>
        /// Checks if a value is in the linked list
        /// O(n) time efficiency
        /// </summary>
        /// <param name="key">Searchable value</param>
        /// <returns>Boolean for if key is in list</returns>
        public bool Includes(int key)
        {
            Current = Head;
            while (Current != null)
            {
                if (Current.Value == key)
                {
                    return true;
                }
                Current = Current.Next;
            }
            return false;
        }

        /// <summary>
        /// Overriding current behavior of ToString method
        /// </summary>
        /// <returns>String containing all values in linked list</returns>
        public override string ToString()
        {
            Current = Head;
            StringBuilder sb = new StringBuilder();
            while (Current != null)
            {
                sb.Append($"{Current.Value} -> ");
                Current = Current.Next;
            }
            sb.Append("NULL");
            return sb.ToString();
        }

        public void Append(int val)
        {
            Current = Head;
            while (Current != null)
            {
                if (Current.Next == null)
                {
                    Current.Next = new Node(val);
                    break;
                }
                Current = Current.Next;
            }
            
        }

        public void InsertBefore(int val, int newVal)
        {
            Current = Head;
            while (Current != null)
            {
                if (Current.Next.Value == val)
                {
                    Node temp = Current;
                    Current = new Node(newVal);
                    Current.Next = temp;
                    break;
                }
                Current = Current.Next;
            }
        }

        public void InsertAfter(int val, int newVal)
        {
            Current = Head;
            while (Current != null)
            {
                if (Current.Value == val)
                {
                    Node temp = Current.Next;
                    Current.Next = new Node(newVal);
                    Current.Next.Next = temp;
                    break;
                }
                Current = Current.Next;
            }
        }
    }
}
