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

        /// <summary>
        /// Append a node to the end of a singly linked list.
        /// </summary>
        /// <param name="val">Value to be appended.</param>
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

        /// <summary>
        /// Insert item before a given value in the singly linked list
        /// </summary>
        /// <param name="val">Value in list</param>
        /// <param name="newVal">New value to be added</param>
        public void InsertBefore(int val, int newVal)
        {
            Current = Head;
            if (Current.Value == val)
            {
                Node temp = Current;
                Current = new Node(newVal);
                Current.Next = temp;
                Head = Current;
                return;
            }
            while (Current.Next != null)
            {
                if (Current.Next.Value == val)
                {
                    Node temp = Current;
                    Current = new Node(newVal);
                    Current.Next = temp.Next;
                    temp.Next = Current;
                    break;
                }
                Current = Current.Next;
            }
        }

        /// <summary>
        /// Insert item before a given value in the singly linked list
        /// </summary>
        /// <param name="val">Value in list</param>
        /// <param name="newVal">New value to be added</param>
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
