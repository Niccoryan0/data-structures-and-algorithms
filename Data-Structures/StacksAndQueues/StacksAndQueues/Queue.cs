using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    public class Queue<T>
    {
        private Node<T> Front { get; set; }
        private Node<T> Rear { get; set; }

        public Queue()
        {
            Rear = Front;
        }

        /// <summary>
        /// Add a node to the end of the queue.
        /// </summary>
        /// <param name="val">Value to be placed in node</param>
        public void Enqueue(T val)
        {
            Node<T> node = new Node<T>(val);

            if (Front == null)
            {
                Front = node;
                Rear = node;
            }
            else
            {
                Rear.Next = node;
                Rear = node;
            }
        }

        /// <summary>
        /// Remove front node from queue
        /// </summary>
        /// <returns>Value of removed node</returns>
        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new Exception("Empty queue");
            }
            T result = Front.Value;
            Front = Front.Next;
            return result;
        }

        /// <summary>
        /// Return top value of a queue or throw exception if empty
        /// </summary>
        /// <returns>Value of top node in queue</returns>
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new Exception("Empty queue");
            }
            return Front.Value;
        }

        /// <summary>
        /// Check if a queue is empty
        /// </summary>
        /// <returns>Boolean for if queue is empty</returns>
        public bool IsEmpty()
        {
            bool result = Front == null ? true : false;
            return result;
        }
    }
}
