# Linked List

*Author: Nicco Ryan*

---

## Description
#### A C# implementation of stacks and queues, creating them from scratch and adding their basic methods.
---

## Methods

| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| Stack - Push | Adds a new `Node` to the top of the `Stack` | O(1) | O(1) | stack.Push("Nicco") |
| Stack - Pop | Removes and returns the value for the top `Node` in the `Stack` or throws an exception if the Stack is empty. | O(1) | O(1) | stack.Pop() |
| Queue - Enqueue | Adds a new `Node` to the front of the `Queue` | O(n) | O(1) | queue.Enqueue("Nicco") |
| Queue - Dequeue | Removes and returns the value for the front `Node` in the `Queue` or throws an exception if the Queue is empty | O(n) | O(1) | queue.Dequeue() |
| Peek | Returns the value for the top/front `Node` of the `Stack/Queue` or throws an exception if it's empty | O(1) | O(1) | stack.Peek() or queue.Peek() |
| IsEmpty | Returns a boolean for if the top/front `Node` in the `Stack/Queue` is empty | O(1) | O(1) | stack.IsEmpty() or queue.IsEmpty() |


---

## Change Log
1.0: *Created all 4 methods for both stack and queue.* - 10 July 2020