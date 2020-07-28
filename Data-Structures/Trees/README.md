# Trees

*Author: Nicco Ryan*

---

## Description
#### A C# implementation of a binary tree with the ability to traverse it pre, in and post order as well as a Binary Search Tree with Add and Contains methods.
---

## Methods

| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| Tree - PreOrder | Traverses the tree and returns the values in PreOrdered form in a List. | O(n) | O(n) | tree.PreOrder() |
| Tree - InOrder | Traverses the tree and returns the values in InOrdered form in a List.  | O(n) | O(n) | tree.InOrder() |
| Tree - PostOrder | Traverses the tree and returns the values in PostOrdered form in a List.  | O(n) | O(n) | tree.PostOrder() |
| Binary Search Tree - Add | Adds a new `Node` with the specified value to the correct place in the Binary Search Tree | O(log n) | O(1) | binaryTree.Add(10) |
| Binary Search Tree - Find | Traverses a binary tree to search for a specified value and returns the value if it's found | O(n) | O(h) | binaryTree.Find(1) |
| Binary Search Tree - Contains | Traverses a binary tree to search for a specified value and returns a boolean of whether it's found | O(n) | O(h) | binaryTree.Contains(1) |



---

## Change Log
1.0: *Class Library Creation* 7/24/2020