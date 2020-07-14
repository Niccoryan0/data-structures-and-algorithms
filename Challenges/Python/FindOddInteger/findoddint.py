# Given an array, find the integer that appears an odd number of times.

# There will always be only one integer that appears an odd number of times.

def find_it(seq):
    for i in range(len(seq)):
        counter = 0;
        for j in range(len(seq)):
            if seq[i] == seq[j]: counter+=1
        if counter % 2 != 0: return seq[i]

print(find_it([20,1,-1,2,-2,3,3,5,5,1,2,4,20,4,-1,-2,5])) # 5
print(find_it([1,1,2,-2,5,2,4,4,-1,-2,5])) # -1
print(find_it([20,1,1,2,2,3,3,5,5,4,20,4,5])) # 5
print(find_it([10])) # 10
print(find_it([1,1,1,1,1,1,10,1,1,1,1])) # 10