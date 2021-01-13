# You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.

# You may assume the two numbers do not contain any leading zero, except the number 0 itself.

class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

def addTwoNumbers(self, l1: ListNode, l2: ListNode) -> ListNode:
    s1 = ""
    while(l1):
        s1 += str(l1.val)
        l1 = l1.next
    n1 = int(s1[::-1])
    s2 = ""
    while(l2):
        s2 += str(l2.val)
        l2 = l2.next
    n2 = int(s2[::-1])
    result = str(n1+n2)[::-1]
    head = ListNode(result[0])
    current = head
    for i in range(1, len(result)):
        current.next = ListNode(result[i])
        current = current.next
    return head