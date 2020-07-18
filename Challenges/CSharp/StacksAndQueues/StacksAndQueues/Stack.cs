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
            if(Top == null)
            {
                throw new Exception("Empty stack");
            }
            string result = Top.Value;
            Top = Top.Next;
            return result;
        }
    }
}
