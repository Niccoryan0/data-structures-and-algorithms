# Implement the myAtoi(string s) function, which converts a string to a 32-bit signed integer (similar to C/C++'s atoi function).

# The algorithm for myAtoi(string s) is as follows:

# Read in and ignore any leading whitespace.
# Check if the next character (if not already at the end of the string) is '-' or '+'. Read this character in if it is either. This determines if the final result is negative or positive respectively. Assume the result is positive if neither is present.
# Read in next the characters until the next non-digit charcter or the end of the input is reached. The rest of the string is ignored.
# Convert these digits into an integer (i.e. "123" -> 123, "0032" -> 32). If no digits were read, then the integer is 0. Change the sign as necessary (from step 2).
# If the integer is out of the 32-bit signed integer range [-231, 231 - 1], then clamp the integer so that it remains in the range. Specifically, integers less than -231 should be clamped to -231, and integers greater than 231 - 1 should be clamped to 231 - 1.
# Return the integer as the final result.
# Note:

# Only the space character ' ' is considered a whitespace character.
# Do not ignore any characters other than the leading whitespace or the rest of the string after the digits.

def myAtoi(self, s: str) -> int:
    s = list(map(str, s.strip()))

    print(s)

    if(not len(s)):
        return 0

    # Create a multiplier for controlling whether the output will be negative or positive
    mult = 1
    if s[0] == '-' or s[0] == '+':
        mult = -1 if s[0] == '-' else 1
        # Slice the sign off once
        s = s[1:]

    result = 0
    for num in s:
        if num.isdigit():
            # Multiply by 10 and then add the number to extend the result instead of adding to it
            result = result * 10 + int(num)
        else:
            break

    # Cap for 32bit signed integer limit
    if result >= 2**31:
        return -2**31 if mult < 0 else 2**31 - 1
    return result * mult
