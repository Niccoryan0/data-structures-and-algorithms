# Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

# An input string is valid if:

# Open brackets must be closed by the same type of brackets.
# Open brackets must be closed in the correct order.

def isValid(self, s: str) -> bool:
    start = "([{"
    end = ")]}"
    temp = []
    for letter in s:
      # If the letter is an opening, add the corresponding close to temp stack
        if letter in start:
            temp.append(end[start.index(letter)]) 
        elif letter in end:
          # If doesnt match the top of the stack, or the stack is empty, it's invalid
            if not len(temp) or temp[-1] != letter:
                return False
          # Pop it from the stack if it's a valid pair
            temp.pop()
    # If the stack is empty, input string is valid.
    return len(temp) == 0