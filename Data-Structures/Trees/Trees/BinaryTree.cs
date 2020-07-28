using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace Trees
{
    public class BinaryTree : Tree<int>
    {
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

        public Node<int> Find(int value)
        {
            return Find(value, Root);
        }

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

        public bool Contains(int value)
        {
            return Contains(value, Root);
        }

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
