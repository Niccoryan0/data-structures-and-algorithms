# Given: an array containing hashes of names

# Return: a string formatted as a list of names separated by commas except for the last two names, which should be separated by an ampersand.

def namelist(names):
    result = ''
    if len(names) == 1:
        result += names[0]['name']
    elif len(names) >= 2:
        lastTwo = f'{names[-2]["name"]} & {names[-1]["name"]}'
        for i in range(len(names)-2):
            result += names[i]['name'] + ', '
        result += lastTwo

    return result

print(namelist([ {name: 'Bart'}, {name: 'Lisa'}, {name: 'Maggie'} ])) # returns 'Bart, Lisa & Maggie'
print(namelist([ {name: 'Bart'}, {name: 'Lisa'} ])) # returns 'Bart & Lisa'
print(namelist([ {name: 'Bart'} ])) # returns 'Bart'