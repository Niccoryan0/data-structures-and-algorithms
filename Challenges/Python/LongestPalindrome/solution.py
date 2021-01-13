# Given a string s, return the longest palindromic substring in s.

def longestPalindrome(self, s: str) -> str:
    result = ""
    temp = 0
    for i in range(len(s)):
#             First case, checking for odd length palindromes
        p1, p2 = i, i
        while p1 >= 0 and p2 < len(s) and s[p1] == s[p2]:
#             If we find a palindrome longer than the current result, update result and temp
            if (p2 - p1 + 1) > temp:
                result = s[p1:p2+1]
                temp = p2 - p1 + 1
#               Move pointers in opposite directions
            p1 -= 1
            p2 += 1
#             Second case, checking for even length palindromes
        p1, p2 = i, i+1
        while p1 >= 0 and p2 < len(s) and s[p1] == s[p2]:
            if(p2 - p1 + 1) > temp:
                result = s[p1:p2+1]
                temp = p2 - p1 + 1
            p1 -= 1
            p2 += 1
    return result
