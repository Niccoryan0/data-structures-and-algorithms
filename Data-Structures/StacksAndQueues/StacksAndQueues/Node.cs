using System;

namespace StacksAndQueues
{
    public class Node
    {
        public string Value { get; set; }
        public Node Next { get; set; }

        public Node(string val)
        {
            Value = val;
        }
    }
}
