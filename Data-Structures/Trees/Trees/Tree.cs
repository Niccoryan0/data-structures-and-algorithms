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

        /// <summary>
        /// Tree constructor with generic Root node
        /// </summary>
        /// <param name="value"></param>
        public Tree(T value)
        {
            Root = new Node<T>(value);
        }

        /// <summary>
        /// PreOrder traversal of a BT
        /// </summary>
        /// <param name="root">Root of the tree</param>
        /// <returns>List in PreOrder form of nodes in tree</returns>
        public List<T> PreOrder(Node<T> root)
        {
            List<T> result = new List<T>();
            PreOrder(result, root);
            return result;
        }

        /// <summary>
        /// Recursive helper for PreOrder traversal
        /// </summary>
        /// <param name="result">List result to add to</param>
        /// <param name="root">Current node in recursion, start at root</param>
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

        /// <summary>
        /// InOrder traversal of a BT
        /// </summary>
        /// <param name="root">Root of the tree</param>
        /// <returns>List in InOrder form of nodes in tree</returns>
        public List<T> InOrder(Node<T> root)
        {
            List<T> result = new List<T>();
            InOrder(result, root);
            return result;
        }

        /// <summary>
        /// Recursive helper for InOrder traversal
        /// </summary>
        /// <param name="result">List result to add to</param>
        /// <param name="root">Current node in recursion, start at root</param>
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

        /// <summary>
        /// PostOrder traversal of a BT
        /// </summary>
        /// <param name="root">Root of the tree</param>
        /// <returns>List in PostOrder form of nodes in tree</returns>
        public List<T> PostOrder(Node<T> root)
        {
            List<T> result = new List<T>();
            PostOrder(result, root);
            return result;
        }

        /// <summary>
        /// Recursive helper for PostOrder traversal
        /// </summary>
        /// <param name="result">List result to add to</param>
        /// <param name="root">Current node in recursion, start at root</param>
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

        /// <summary>
        /// Find the maximum value in a BT
        /// </summary>
        /// <param name="root">Current node in recursion, starts at tree's root</param>
        /// <returns>Maximum value in tree</returns>
        public int FindMaximumValue(Node<int> root)
        {
            if (root == null)
            {
                return int.MinValue;
            }
            int result = root.Value;
            int left = FindMaximumValue(root.LC);
            int right = FindMaximumValue(root.RC);
            if (result < left)
            {
                result = left;
            }
            if (result < right)
            {
                result = right;
            }
            return result;
        }
    }
}
