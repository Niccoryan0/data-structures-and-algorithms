# Write an algorithm that will identify valid IPv4 addresses in dot-decimal format. IPs should be considered valid if they consist of four octets, with values between 0 and 255, inclusive.

# Input to the function is guaranteed to be a single string.

import re;
def is_valid_IP(strng):
    numArr = strng.split('.')
    if len(numArr) != 4:
        return False
    for i in range(len(numArr)):
        if len(numArr[i]) > 1 and numArr[i][0] == '0':
            return False
        if not numArr[i].isdecimal() or int(numArr[i]) < 0 or int(numArr[i]) > 255:
            return False
    return True

print(is_valid_IP(1.2.3.4)) # True
print(is_valid_IP(123.45.67.89)) #True
print(is_valid_IP(1.2.3)) # False
print(is_valid_IP(123.045.067.089)) # False