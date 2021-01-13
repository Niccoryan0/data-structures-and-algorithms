

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