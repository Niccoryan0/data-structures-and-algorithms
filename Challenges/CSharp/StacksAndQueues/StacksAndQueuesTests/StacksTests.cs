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

            Assert.Equal("hello", stack.Top.Value);
        }

        [Fact]
        public void CanPushMultipleToStack()
        {
            Stack stack = new Stack();
            stack.Push("hello");
            stack.Push("world");
            stack.Push("stackin");


            Assert.Equal("stackin", stack.Top.Value);
            Assert.Equal("world", stack.Top.Next.Value);
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
            Assert.Null(stack.Top);
        }

    }
}
