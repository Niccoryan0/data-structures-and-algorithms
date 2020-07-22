using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    public class Stack<T>
    {
        public Node<T> Top { get; set; }

        /// <summary>
        /// Push a node to the top of the stack.
        /// </summary>
        /// <param name="value">Value to be stored in the node</param>
        public void Push(T value)
        {
            Node<T> node = new Node<T>(value);
            node.Next = Top;
            Top = node;
        }
        
        /// <summary>
        /// Pop the top value of the Stack or throws an exception if empty.
        /// </summary>
        /// <returns>Popped node's value</returns>
        public T Pop()
        {
            if(IsEmpty())
            {
                throw new Exception("Empty stack");
            }
            T result = Top.Value;
            Top = Top.Next;
            return result;
        }

        /// <summary>
        /// Return the top node's value or throws an exception if empty.
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new Exception("Empty stack");
            }
            return Top.Value;
        }

        /// <summary>
        /// Check if the stack is empty and return boolean
        /// </summary>
        /// <returns>Boolean for if stack is empty</returns>
        public bool IsEmpty()
        {
            bool result = Top == null ? true : false;
            return result;
        }

    }
}
