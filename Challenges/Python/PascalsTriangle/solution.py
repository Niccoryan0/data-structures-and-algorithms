# In mathematics, Pascal's triangle is a triangular array of the binomial coefficients expressed with formula (n k) = n!/(n-k)!, where n denotes a row of the triangle, and k is a position of a term in the row.

# Pascal's Triangle

# You can read Wikipedia article on Pascal's Triangle for more information.

# Task
# Write a function that, given a depth n, returns n top rows of Pascal's Triangle flattened into a one-dimensional list/array.

# n guarantees that terms of the Triangle won't overflow.

# Example:
# n = 1: [1]
# n = 2: [1,  1, 1]
# n = 4: [1,  1, 1,  1, 2, 1,  1, 3, 3, 1]

def pascals_triangle(n):
  result = [[1], [1, 1]]
  raw = [1, 1, 1]
  if n < 2: return [1]
  elif n < 3: return raw[0:n+1]
  while len(result) < n:
      current = [1]
      raw.append(1)
      previous = result[-1]
      for i in range(len(previous)-1):
          current.append(previous[i] + previous[i+1])
          raw.append(previous[i] + previous[i+1])
      current.append(1)
      raw.append(1)
      result.append(current)
  return raw