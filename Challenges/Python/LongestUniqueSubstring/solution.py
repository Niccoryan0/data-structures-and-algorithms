# Given a string s, find the length of the longest substring without repeating characters.


def lengthOfLongestSubstring(self, s: str) -> int:
    current = set()
    i = 0
    while(i < len(s)):
        temp = set()
        j = i
        while(j < len(s) and s[j] not in temp):
            temp.add(s[j])
            j += 1
        if (len(temp) > len(current)):
            current = temp
        i += 1
    return len(current)