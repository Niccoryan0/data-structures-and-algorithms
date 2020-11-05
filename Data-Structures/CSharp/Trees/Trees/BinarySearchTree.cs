using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace Trees
{
    public class BinarySearchTree : Tree<int>
    {
        /// <summary>
        /// Add a value to the BST
        /// </summary>
        /// <param name="value">Value to be added</param>
        public void Add(int value)
        {
            Node<int> temp = null, current = Root, newNode = new Node<int>(value);
            if (current == null)
            {
                Root = newNode;
                return;
            }
            while (current != null)
            {
                temp = current;
                if (value < current.Value)
                {
                    current = current.LC;
                } else if (value > current.Value)
                {
                    current = current.RC;
                }else
                {
                    throw new Exception("Value already in tree");
                }
            }
            if (value < temp.Value)
            {
                temp.LC = newNode;
            } else
            {
                temp.RC = newNode;
            }
        }

        /// <summary>
        /// Check and return a value if it is in a BinarySearchTree, calls recursive method Contains
        /// </summary>
        /// <param name="value">Value to be searched for</param>
        /// <returns>Boolean for if value was found</returns>
        public Node<int> Find(int value)
        {
            return Find(value, Root);
        }

        /// <summary>
        /// Recursive helper for find
        /// </summary>
        /// <param name="value">Value to be searched for</param>
        /// <param name="node">Current node of recursion, starts at root</param>
        /// <returns>Node containing value or null if not found</returns>
        public Node<int> Find(int value, Node<int> node)
        {
            if (node != null)
            {
                if (value == node.Value) return node;
                if (value < node.Value)
                {
                    return Find(value, node.LC);
                }
                else
                {
                    return Find(value, node.RC);
                }
            }
            return null;
        }

        /// <summary>
        /// Check if a value is in a BinarySearchTree, calls recursive method Contains
        /// </summary>
        /// <param name="value">Value to be searched for</param>
        /// <returns>Boolean for if value was found</returns>
        public bool Contains(int value)
        {
            return Contains(value, Root);
        }

        /// <summary>
        /// Recursive helper for Contains method
        /// </summary>
        /// <param name="value">Value to be searched for</param>
        /// <param name="node">Current node of recursion, start at root</param>
        /// <returns></returns>
        public bool Contains(int value, Node<int> node)
        {
            if (node != null)
            {
                if (value == node.Value) return true;
                if (value < node.Value)
                {
                    return Contains(value, node.LC);
                }
                else
                {
                    return Contains(value, node.RC);
                }
            }
            return false;
        }
    }
}