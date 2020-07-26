using System;
using Xunit;
using QueueWithStacks;
using StacksAndQueues;

namespace QueueWithStacksTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanEnqueueValue()
        {
            PseudoQueue queue = new PseudoQueue();
            queue.Enqueue("nicco");
            Assert.Equal("nicco", queue.Front.Value);
        }

        [Fact]
        public void CanEnqueueMultipleValues()
        {
            PseudoQueue queue = new PseudoQueue();
            queue.Enqueue("nicco");
            queue.Enqueue("ryan");
            queue.Enqueue("software");
            queue.Enqueue("dev");

            Assert.Equal("nicco", queue.Front.Value);
        }

        [Fact]
        public void CanDequeueValue()
        {
            PseudoQueue queue = new PseudoQueue();
            queue.Enqueue("nicco");
            string result = queue.Dequeue();
            Assert.Equal("nicco", result);
        }

        [Fact]
        public void CanEmptyQueue()
        {
            PseudoQueue queue = new PseudoQueue();
            queue.Enqueue("nicco");
            queue.Enqueue("ryan");
            queue.Enqueue("dev");
            string result1 = queue.Dequeue();
            queue.Dequeue();
            string result3 = queue.Dequeue();
            Assert.Equal("nicco", result1);
            Assert.Equal("dev", result3);

            Assert.Null(queue.Front);
        }

        [Fact]
        public void CanThrowExceptionOnEmptyDequeue()
        {
            PseudoQueue queue = new PseudoQueue();
            var result = Assert.Throws<Exception>(() => queue.Dequeue());
            Assert.Equal("Empty pseudoqueue", result.Message);
        }
    }
}
