using System;
using Xunit;
using Trees;
using static TreeIntersection.TreeIntersection;
using System.Collections.Generic;

namespace TreeIntersectionTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturnRepeatValues()
        {
            Tree<int> tree1 = new Tree<int>();

            Node<int> root = new Node<int>(100);
            Node<int> b = new Node<int>(167);
            Node<int> c = new Node<int>(3);
            Node<int> d = new Node<int>(44);
            Node<int> e = new Node<int>(83);
            Node<int> f = new Node<int>(108);
            Node<int> g = new Node<int>(55);

            tree1.Root = root;
            root.LC = b;
            root.RC = c;
            b.LC = d;
            b.RC = e;
            c.LC = f;
            c.RC = g;           
            Tree<int> tree2 = new Tree<int>();

            Node<int> root2 = new Node<int>(18);
            Node<int> h = new Node<int>(44);
            Node<int> i = new Node<int>(9);
            Node<int> j = new Node<int>(108);
            Node<int> k = new Node<int>(83);
            Node<int> l = new Node<int>(17);
            Node<int> m = new Node<int>(5);

            tree2.Root = root2;
            root2.LC = h;
            root2.RC = i;
            h.LC = j;
            h.RC = k;
            i.LC = l;
            i.RC = m;

            List<int> result = FindIntersection(tree1, tree2);
            List<int> expected = new List<int>() { 44, 108, 83 };

            Assert.Equal(expected, result);
        }          
        
        [Fact]
        public void CanReturnAllRepeatedValues()
        {
            Tree<int> tree1 = new Tree<int>();

            Node<int> root = new Node<int>(100);
            Node<int> b = new Node<int>(167);
            Node<int> c = new Node<int>(3);
            Node<int> d = new Node<int>(44);
            Node<int> e = new Node<int>(83);
            Node<int> f = new Node<int>(108);
            Node<int> g = new Node<int>(55);

            tree1.Root = root;
            root.LC = b;
            root.RC = c;
            b.LC = d;
            b.RC = e;
            c.LC = f;
            c.RC = g;           
            Tree<int> tree2 = new Tree<int>();

            Node<int> root2 = new Node<int>(55);
            Node<int> h = new Node<int>(108);
            Node<int> i = new Node<int>(83);
            Node<int> j = new Node<int>(100);
            Node<int> k = new Node<int>(167);
            Node<int> l = new Node<int>(3);
            Node<int> m = new Node<int>(44);

            tree2.Root = root2;
            root2.LC = h;
            root2.RC = i;
            h.LC = j;
            h.RC = k;
            i.LC = l;
            i.RC = m;

            List<int> result = FindIntersection(tree1, tree2);
            List<int> expected = new List<int>() { 55, 108, 100, 167, 83, 3, 44 };

            Assert.Equal(expected, result);
        }      
        
        [Fact]
        public void CanReturnEmptyListForNoMatches()
        {
            Tree<int> tree1 = new Tree<int>();

            Node<int> root = new Node<int>(100);
            Node<int> b = new Node<int>(167);
            Node<int> c = new Node<int>(3);
            Node<int> d = new Node<int>(44);
            Node<int> e = new Node<int>(83);
            Node<int> f = new Node<int>(108);
            Node<int> g = new Node<int>(55);

            tree1.Root = root;
            root.LC = b;
            root.RC = c;
            b.LC = d;
            b.RC = e;
            c.LC = f;
            c.RC = g;           
            Tree<int> tree2 = new Tree<int>();

            Node<int> root2 = new Node<int>(18);
            Node<int> h = new Node<int>(4);
            Node<int> i = new Node<int>(9);
            Node<int> j = new Node<int>(11);
            Node<int> k = new Node<int>(84);
            Node<int> l = new Node<int>(17);
            Node<int> m = new Node<int>(5);

            tree2.Root = root2;
            root2.LC = h;
            root2.RC = i;
            h.LC = j;
            h.RC = k;
            i.LC = l;
            i.RC = m;

            List<int> result = FindIntersection(tree1, tree2);
            List<int> expected = new List<int>() { };

            Assert.Equal(expected, result);
        }
    }
}
