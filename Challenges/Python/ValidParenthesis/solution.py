# Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

# An input string is valid if:

# Open brackets must be closed by the same type of brackets.
# Open brackets must be closed in the correct order.

def isValid(self, s: str) -> bool:
    start = "([{"
    end = ")]}"
    temp = []
    for letter in s:
        if letter in start:
            temp.append(end[start.index(letter)])
        elif letter in end:
            if not len(temp) or temp[-1] != letter:
                return False
            temp.pop()
    return len(temp) == 0