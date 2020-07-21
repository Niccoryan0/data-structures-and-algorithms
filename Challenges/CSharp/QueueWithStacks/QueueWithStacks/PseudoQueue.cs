using System;
using System.Collections.Generic;
using System.Text;
using StacksAndQueues;

namespace QueueWithStacks
{
    public class PseudoQueue
    {
        public Stack Stack1 { get; set; } = new Stack();
        public Stack Stack2 { get; set; } = new Stack();
        public Node Front { get; set; }

        public void Enqueue(string val)
        {
            if(Stack1.Top == null)
            {
                Stack1.Push(val);
                Front = Stack1.Top;
            } else
            {
                while(Stack1.Top != null)
                {
                    Stack2.Push(Stack1.Pop());
                }
                Stack1.Push(val);
                while (Stack2.Top != null)
                {
                    Stack1.Push(Stack2.Pop());
                }
                Front = Stack1.Top;
            }
        }

        public string Dequeue()
        {
            if (Stack1.Top == null)
            {
                throw new Exception("Empty pseudoqueue");
            }
            else
            {
                string result = Stack1.Pop();
                Front = Stack1.Top;
                return result;
            }
        }
    }
}
