using System;
using Xunit;
using Trees;
using System.Collections.Generic;

namespace Treests
{
    public class TreeTests
    {
        [Fact]
        public void CanInstantiateAnEmtpyTree()
        {
            Tree<string> tree = new Tree<string>();
            Assert.Null(tree.Root);
        }

        [Fact]
        public void CanInstantiateTreeWithSingleRoot()
        {
            Tree<string> tree = new Tree<string>("Josie Cat");

            Assert.NotNull(tree.Root);
            Assert.Equal("Josie Cat", tree.Root.Value);
            Assert.IsType<Node<string>>(tree.Root);
        }


        [Fact]
        public void CanAddLeftAndRightToRoot()
        {
            Tree<char> tree = new Tree<char>('a');

            Node<char> LC = new Node<char>('b');
            Node<char> RC = new Node<char>('c');

            tree.Root.LC = LC;
            tree.Root.RC = RC;

            Assert.Equal('b', tree.Root.LC.Value);
            Assert.Equal('c', tree.Root.RC.Value);
        }

        [Fact]
        public void CanSuccesfullyDoPreOrderTraversal()
        {
            Tree<char> tree = new Tree<char>();

            Node<char> root = new Node<char>('a');
            Node<char> b = new Node<char>('b');
            Node<char> c = new Node<char>('c');
            Node<char> d = new Node<char>('d');
            Node<char> e = new Node<char>('e');
            Node<char> f = new Node<char>('f');
            Node<char> g = new Node<char>('g');

            tree.Root = root;

            root.LC = b;
            root.RC = c;

            b.LC = d;
            b.RC = e;

            c.LC = f;
            c.RC = g;


            List<char> expected = new List<char>() { 'a', 'b', 'd', 'e', 'c', 'f', 'g' };

            List<char> preOrder = tree.PreOrder(tree.Root);

            Assert.Equal(expected, preOrder);
        }

        [Fact]
        public void CanSuccesfullyDoInOrderTraversal()
        {
            Tree<char> tree = new Tree<char>();

            Node<char> root = new Node<char>('a');
            Node<char> b = new Node<char>('b');
            Node<char> c = new Node<char>('c');
            Node<char> d = new Node<char>('d');
            Node<char> e = new Node<char>('e');
            Node<char> f = new Node<char>('f');
            Node<char> g = new Node<char>('g');

            tree.Root = root;

            root.LC = b;
            root.RC = c;

            b.LC = d;
            b.RC = e;

            c.LC = f;
            c.RC = g;


            List<char> expected = new List<char>() { 'd', 'b', 'e', 'a', 'f', 'c', 'g' };


            List<char> preOrder = tree.InOrder(tree.Root);

            Assert.Equal(expected, preOrder);
        }

        [Fact]
        public void CanSuccesfullyDoPostOrderTraversal()
        {
            // arrange

            Tree<char> tree = new Tree<char>();

            Node<char> root = new Node<char>('a');
            Node<char> b = new Node<char>('b');
            Node<char> c = new Node<char>('c');
            Node<char> d = new Node<char>('d');
            Node<char> e = new Node<char>('e');
            Node<char> f = new Node<char>('f');
            Node<char> g = new Node<char>('g');

            tree.Root = root;

            root.LC = b;
            root.RC = c;
            b.LC = d;
            b.RC = e;
            c.LC = f;
            c.RC = g;

            List<char> expected = new List<char>() { 'd', 'e', 'b', 'f', 'g', 'c', 'a' };
            List<char> preOrder = tree.PostOrder(tree.Root);

            Assert.Equal(expected, preOrder);
        }

        [Fact]
        public void CanFindMaximumValue()
        {
            // arrange

            Tree<int> tree = new Tree<int>();

            Node<int> root = new Node<int>(100);
            Node<int> b = new Node<int>(167);
            Node<int> c = new Node<int>(3);
            Node<int> d = new Node<int>(44);
            Node<int> e = new Node<int>(83);
            Node<int> f = new Node<int>(108);
            Node<int> g = new Node<int>(55);

            tree.Root = root;

            root.LC = b;
            root.RC = c;
            b.LC = d;
            b.RC = e;
            c.LC = f;
            c.RC = g;

            int result = tree.FindMaximumValue(tree.Root);

            Assert.Equal(167, result);
        }

        [Fact]
        public void CanFindMaximumValueWithAllNegatives()
        {
            // arrange

            Tree<int> tree = new Tree<int>();

            Node<int> root = new Node<int>(-100);
            Node<int> b = new Node<int>(-167);
            Node<int> c = new Node<int>(-3);
            Node<int> d = new Node<int>(-44);
            Node<int> e = new Node<int>(-83);
            Node<int> f = new Node<int>(-108);
            Node<int> g = new Node<int>(-55);

            tree.Root = root;

            root.LC = b;
            root.RC = c;
            b.LC = d;
            b.RC = e;
            c.LC = f;
            c.RC = g;

            int result = tree.FindMaximumValue(tree.Root);

            Assert.Equal(-3, result);
        }

        [Fact]
        public void CanGetEvenSum()
        {
            Tree<int> tree = new Tree<int>();

            Node<int> root = new Node<int>(100);
            Node<int> b = new Node<int>(167);
            Node<int> d = new Node<int>(44);
            Node<int> e = new Node<int>(83);
            Node<int> c = new Node<int>(3);
            Node<int> f = new Node<int>(108);
            Node<int> g = new Node<int>(55);

            tree.Root = root;

            root.LC = b;
            root.RC = c;
            b.LC = d;
            b.RC = e;
            c.LC = f;
            c.RC = g;

            int result = tree.GetEvenSum(tree);

            Assert.Equal(252, result);
        }
    }
}
