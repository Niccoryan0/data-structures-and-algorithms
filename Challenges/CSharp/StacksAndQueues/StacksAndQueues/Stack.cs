using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    public class Stack
    {
        public Node Top { get; set; }

        public void Push(string value)
        {
            Node node = new Node(value);
            node.Next = Top;
            Top = node;
        }

        public string Pop()
        {
            if(IsEmpty())
            {
                throw new Exception("Empty stack");
            }
            string result = Top.Value;
            Top = Top.Next;
            return result;
        }

        public string Peek()
        {
            if (IsEmpty())
            {
                throw new Exception("Empty stack");
            }
            return Top.Value;
        }

        public bool IsEmpty()
        {
            bool result = Top == null ? true : false;
            return result;
        }

    }
}
