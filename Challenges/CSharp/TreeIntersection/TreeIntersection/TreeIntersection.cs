using System;
using System.Collections.Generic;
using Trees;

namespace TreeIntersection
{
    public class TreeIntersection
    {
        public static List<int> FindIntersection(Tree<int> tree1, Tree<int> tree2)
        {
            HashSet<int> set = new HashSet<int>();
            List<int> result = new List<int>();
            TraverseTree(tree1.Root, set, result);
            TraverseTree(tree2.Root, set, result);
            return result;
        }

        public static void TraverseTree(Node<int> root, HashSet<int> set, List<int> result)
        {
            if (!set.Add(root.Value)) result.Add(root.Value);
            if(root.LC != null)
            {
                TraverseTree(root.LC, set, result);
            }
            if(root.RC != null)
            {
                TraverseTree(root.RC, set, result);
            }
        }
    }
}
