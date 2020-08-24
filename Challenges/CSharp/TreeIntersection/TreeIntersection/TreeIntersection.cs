using System;
using System.Collections.Generic;
using Trees;

namespace TreeIntersection
{
    public class TreeIntersection
    {
        /// <summary>
        /// Handle the creation of the HashSet and Result List, then call the TraverseTree recursive method for both input trees
        /// </summary>
        /// <param name="tree1">The first tree to be checked</param>
        /// <param name="tree2">The second tree to be checked</param>
        /// <returns>List of all integers found in both trees</returns>
        public static List<int> FindIntersection(Tree<int> tree1, Tree<int> tree2)
        {
            HashSet<int> set = new HashSet<int>();
            List<int> result = new List<int>();
            TraverseTree(tree1.Root, set, result);
            TraverseTree(tree2.Root, set, result);
            return result;
        }

        /// <summary>
        /// Traverse the tree attempting to add each item to the set, if it can't be added to the set it's added to the result.
        /// </summary>
        /// <param name="root">Current root in recursion</param>
        /// <param name="set">HashSet of all values in tree, used to find repeated values as they can't be added to it twice</param>
        /// <param name="result">List representing currently found repeated numbers</param>
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
