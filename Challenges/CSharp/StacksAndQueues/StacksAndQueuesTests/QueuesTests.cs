using System;
using System.Collections;
using Xunit;
using StacksAndQueues;
using Queue = StacksAndQueues.Queue;

namespace StacksAndQueuesTests
{
    public class QueuesTests
    {
        [Fact]
        public void CanEnqueueIntoQueue()
        {
            Queue queue = new Queue();

            queue.Enqueue("Nicco");

            Assert.Equal("Nicco", queue.Peek());
        }

        [Fact]
        public void CanEnqueueMultipleIntoQueue()
        {
            Queue queue = new Queue();

            queue.Enqueue("Nicco");
            queue.Enqueue("Ryan");
            queue.Enqueue("Redhawk");


            Assert.Equal("Nicco", queue.Peek());

        }

        [Fact]
        public void CanDequeueFromQueue()
        {
            Queue queue = new Queue();

            queue.Enqueue("Nicco");
            queue.Enqueue("Ryan");
            queue.Enqueue("Redhawk");
            string result = queue.Dequeue();

            Assert.Equal("Ryan", queue.Peek());
            Assert.Equal("Nicco", result);
        }

        [Fact]
        public void CanPeekIntoQueue()
        {
            Queue queue = new Queue();
            queue.Enqueue("Nicco");
            Assert.Equal("Nicco", queue.Peek());
        }

        [Fact]
        public void CanEmptyQueue()
        {
            Queue queue = new Queue();

            queue.Enqueue("Nicco");
            queue.Enqueue("Ryan");
            queue.Enqueue("Redhawk");
            queue.Dequeue();
            queue.Dequeue();
            string result = queue.Dequeue();

            Assert.True(queue.IsEmpty());
            Assert.Equal("Redhawk", result);
        }

        [Fact]
        public void CanInstantiateEmptyQueue()
        {
            Queue queue = new Queue();
            Assert.True(queue.IsEmpty());
        }

        [Fact]
        public void CanInstantiateEmptyQueue()
        {
            Queue queue = new Queue();
            Assert.True(queue.IsEmpty());
        }
    }
}
