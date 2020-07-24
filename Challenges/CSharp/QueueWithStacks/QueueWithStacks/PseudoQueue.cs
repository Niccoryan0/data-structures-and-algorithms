using System;
using System.Collections.Generic;
using System.Text;
using StacksAndQueues;

namespace QueueWithStacks
{
    public class PseudoQueue
    { 
        public StacksAndQueues.Stack<string> Stack1 { get; set; } = new StacksAndQueues.Stack<string>();
        public StacksAndQueues.Stack<string> Stack2 { get; set; } = new StacksAndQueues.Stack<string>();
        public Node<string> Front { get; set; }

        /// <summary>
        /// Add a new item to the "rear" of the queue, which is actually the bottom of the primary stack
        /// </summary>
        /// <param name="val">Value to be enqueued</param>
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

        /// <summary>
        /// Remove and return the "front" of the queue, which is actually the top of the primary stack.
        /// </summary>
        /// <returns>Front node in queue</returns>
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
