# Move the first letter of each word to the end of it, then add "ay" to the end of the word. Leave punctuation marks untouched.

def pig_it(text):
    alphabet = 'abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ'
    text = text.split(' ')
    result = []
    for i in range(len(text)):
        if text[i] in alphabet and len(text[i]) == 1:
            text[i] = text[i]+'ay'
        elif len(text[i]) >= 2:
            text[i] = text[i][1:-1]+text[i][-1]+text[i][0]+'ay'
        result.append(text[i])
    return ' '.join(result)

print(pig_it('Pig latin is cool')) # igPay atinlay siay oolcay
print(pig_it('Hello world !'))     # elloHay orldway !
