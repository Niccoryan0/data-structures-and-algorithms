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
        public Node Rear { get; set; }

        public PseudoQueue()
        {
            Rear = Front;
        }

        public void Enqueue(string val)
        {
            if(Stack1.Top == null)
            {
                Stack1.Push(val);
                Front = Stack1.Top;
                Rear = Stack1.Top;
            } else
            {
                while(Stack1.Top != null)
                {
                    Stack2.Push(Stack1.Pop());
                }
                Stack1.Push(val);
                Rear = Stack1.Top;
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
                Node current = Stack1.Top;
                while (current != null)
                {
                    current = current.Next;
                }
                Rear = current;
                Front = Stack1.Top;
                return result;
            }
        }
    }
}
