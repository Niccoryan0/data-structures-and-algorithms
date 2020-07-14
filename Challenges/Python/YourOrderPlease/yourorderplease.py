# Your task is to sort a given string. Each word in the string will contain a single number. This number is the position the word should have in the result.

# Note: Numbers can be from 1 to 9. So 1 will be the first word (not 0).

# If the input string is empty, return an empty string. The words in the input String will only contain valid consecutive numbers.

def order(sentence):
  result = [''] * len(sentence.split(' '))
  for word in sentence.split(' '):
      for symbol in word:
          if symbol.isdecimal():
              result[int(symbol)-1] += word
  return ' '.join(result)

print(order("is2 Thi1s T4est 3a"))
print(order("4of Fo1r pe6ople g3ood th5e the2"))