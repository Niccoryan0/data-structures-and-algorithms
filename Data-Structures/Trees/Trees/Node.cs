using System;

namespace Trees
{
    public class Node<T>
    {
        public Node<T> LC { get; set; }
        public Node<T> RC { get; set; }
        public T Value { get; set; }


    }
}
