using System;
using Xunit;
using Trees;
using System.Collections.Generic;

namespace Treests
{
    public class BinarySearchTreeTests
    {
        [Fact]
        public void CanInstantiateAnEmptyBST()
        {
            BinarySearchTree tree = new BinarySearchTree();
            Assert.Null(tree.Root);
        }

        [Fact]
        public void CanAddNodeToBST()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(100);
            Assert.Equal(100, tree.Root.Value);
        }

        [Fact]
        public void CanAddMultipleNodesToBST()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(100);
            tree.Add(50);
            tree.Add(150);
            tree.Add(25);
            tree.Add(75);
            tree.Add(70);
            tree.Add(80);

            Assert.Equal(100, tree.Root.Value);
            Assert.Equal(50, tree.Root.LC.Value);
            Assert.Equal(150, tree.Root.RC.Value);
            Assert.Equal(25, tree.Root.LC.LC.Value);
            Assert.Equal(75, tree.Root.LC.RC.Value);
            Assert.Equal(70, tree.Root.LC.RC.LC.Value);
            Assert.Equal(80, tree.Root.LC.RC.RC.Value);

        }

        [Fact]
        public void CanFindNodeInBST()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(100);
            tree.Add(50);
            tree.Add(150);
            tree.Add(25);
            tree.Add(75);

            Node<int> result = tree.Find(75);

            Assert.Equal(tree.Root.LC.RC, result);
        }

        [Fact]
        public void CanReturnNullIfNodeNodeFound()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(100);
            tree.Add(50);
            tree.Add(150);
            tree.Add(25);
            tree.Add(75);

            Node<int> result = tree.Find(80);

            Assert.Null(result);
        }

        [Fact]
        public void ContainReturnsTrueIfNodeInTree()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(100);
            tree.Add(50);
            tree.Add(150);
            tree.Add(25);
            tree.Add(75);

            bool result = tree.Contains(75);

            Assert.True(result);
        }

        [Fact]
        public void ContainReturnsFalseIfNodeNotInTree()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(100);
            tree.Add(50);
            tree.Add(150);
            tree.Add(25);
            tree.Add(75);

            bool result = tree.Contains(80);

            Assert.False(result);
        }

    }
}
