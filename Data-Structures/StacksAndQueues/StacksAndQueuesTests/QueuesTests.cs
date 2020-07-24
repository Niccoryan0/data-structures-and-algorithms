using System;
using System.Collections;
using Xunit;
using StacksAndQueues;

namespace StacksAndQueuesTests
{
    public class QueuesTests
    {
        [Fact]
        public void CanEnqueueIntoQueue()
        {
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("Nicco");

            Assert.Equal("Nicco", queue.Peek());
        }

        [Fact]
        public void CanEnqueueMultipleIntoQueue()
        {
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("Nicco");
            queue.Enqueue("Ryan");
            queue.Enqueue("Redhawk");


            Assert.Equal("Nicco", queue.Peek());

        }

        [Fact]
        public void CanDequeueFromQueue()
        {
            Queue<string> queue = new Queue<string>();

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
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Nicco");
            Assert.Equal("Nicco", queue.Peek());
        }

        [Fact]
        public void CanEmptyQueue()
        {
            Queue<string> queue = new Queue<string>();

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
            Queue<string> queue = new Queue<string>();
            Assert.True(queue.IsEmpty());
        }

        [Fact]
        public void CanThrowExceptionPeekingAndDequeuingEmpty()
        {
            Queue<string> queue = new Queue<string>();
            var resultPop = Assert.Throws<Exception>(() => queue.Dequeue());
            var resultPeek = Assert.Throws<Exception>(() => queue.Peek());

            Assert.Equal("Empty queue", resultPop.Message);
            Assert.Equal("Empty queue", resultPeek.Message);
        }
    }
}
