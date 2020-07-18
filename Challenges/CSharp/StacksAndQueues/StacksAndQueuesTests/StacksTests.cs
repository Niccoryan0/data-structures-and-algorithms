using System;
using Xunit;
using StacksAndQueues;

namespace StacksAndQueuesTests
{
    public class StacksTests
    {
        [Fact]
        public void CanPushToStack()
        {
            Stack stack = new Stack();
            stack.Push("hello");

            Assert.Equal("hello", stack.Peek());
        }

        [Fact]
        public void CanPushMultipleToStack()
        {
            Stack stack = new Stack();
            stack.Push("hello");
            stack.Push("world");
            stack.Push("stackin");


            Assert.Equal("stackin", stack.Peek());
        }

        [Fact]
        public void CanPopFromStack()
        {
            Stack stack = new Stack();
            stack.Push("hello");
            stack.Push("world");
            stack.Push("stackin");
            string result = stack.Pop();

            Assert.Equal("stackin", result);
        }

        [Fact]
        public void CanEmptyAStack()
        {
            Stack stack = new Stack();
            stack.Push("hello");
            stack.Push("world");
            stack.Push("stackin");
            string result1 = stack.Pop();
            string result2 = stack.Pop();
            string result3 = stack.Pop();

            Assert.Equal("stackin", result1);
            Assert.Equal("world", result2);
            Assert.Equal("hello", result3);
            Assert.True(stack.IsEmpty());
        }

        [Fact]
        public void CanPeekTopNode()
        {
            Stack stack = new Stack();
            stack.Push("hello");
            stack.Push("world");
            stack.Push("stackin");
            string result = stack.Peek();

            Assert.Equal("stackin", result);
        }

        [Fact]
        public void CanCreateEmptyStack()
        {
            Stack stack = new Stack();

            Assert.True(stack.IsEmpty());
        }

        [Fact]
        public void CanThrowExceptionOnEmptyStack()
        {
            Stack stack = new Stack();

            var resultPop = Assert.Throws<Exception>(() => stack.Pop());
            var resultPeek = Assert.Throws<Exception>(() => stack.Peek());

            Assert.Equal("Empty stack", resultPop.Message);
            Assert.Equal("Empty stack", resultPeek.Message);

        }
    }
}
