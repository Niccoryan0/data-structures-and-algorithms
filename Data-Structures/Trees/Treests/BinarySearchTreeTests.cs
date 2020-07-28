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
            BinaryTree tree = new BinaryTree();
            Assert.Null(tree.Root);
        }

        [Fact]
        public void CanAddNodeToBST()
        {
            BinaryTree tree = new BinaryTree();
            tree.Add(100);
            Assert.Equal(100, tree.Root.Value);
        }

        [Fact]
        public void CanAddMultipleNodesToBST()
        {
            BinaryTree tree = new BinaryTree();
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
            BinaryTree tree = new BinaryTree();
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
            BinaryTree tree = new BinaryTree();
            tree.Add(100);
            tree.Add(50);
            tree.Add(150);
            tree.Add(25);
            tree.Add(75);

            Node<int> result = tree.Find(80);

            Assert.Null(result);
        }
    }
}
