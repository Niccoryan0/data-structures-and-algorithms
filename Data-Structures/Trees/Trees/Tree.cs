using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Trees
{
    public class Tree<T>
    {
        public Node<T> Root { get; set; }

        public Tree()
        {

        }

        public Tree(T value)
        {
            Root = new Node<T>(value);
        }

        public List<T> PreOrder(Node<T> root)
        {
            List<T> result = new List<T>();
            PreOrder(result, root);
            return result;
        }

        private void PreOrder(List<T> result, Node<T> root) 
        {
            result.Add(root.Value);
            if (root.LC != null)
            {
                PreOrder(result, root.LC);
            }
            if (root.RC != null)
            {
                PreOrder(result, root.RC);
            }
        }

        public List<T> InOrder(Node<T> root)
        {
            List<T> result = new List<T>();
            InOrder(result, root);
            return result;
        }

        private void InOrder(List<T> result, Node<T> root)
        {
            if (root.LC != null)
            {
                InOrder(result, root.LC);
            }
            result.Add(root.Value);
            if (root.RC != null)
            {
                InOrder(result, root.RC);
            }
        }

        public List<T> PostOrder(Node<T> root)
        {
            List<T> result = new List<T>();
            PostOrder(result, root);
            return result;
        }

        private void PostOrder(List<T> result, Node<T> root)
        {
            if (root.LC != null)
            {
                PostOrder(result, root.LC);
            }
            if (root.RC != null)
            {
                PostOrder(result, root.RC);
            }
            result.Add(root.Value);
        }
    }
}
