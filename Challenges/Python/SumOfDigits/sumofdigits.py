# Digital root is the recursive sum of all the digits in a number.

# Given n, take the sum of the digits of n. If that value has more than one digit, continue reducing in this way until a single-digit number is produced. This is only applicable to the natural numbers.

def digital_root(n):
    while (len(str(n)) > 1):
        temp = 0
        for num in str(n):
            temp += int(num)
        n = temp
    return n
            
print(digital_root(16))
print(digital_root(942))
print(digital_root(132189))
print(digital_root(493193))