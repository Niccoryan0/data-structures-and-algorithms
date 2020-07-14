// Define a function that takes an integer argument and returns logical value true or false depending on if the integer is a prime.

// Per Wikipedia, a prime number (or a prime) is a natural number greater than 1 that has no positive divisors other than 1 and itself.

// Assumptions
// You can assume you will be given an integer input.
// You can not assume that the integer will be only positive. You may be given negative numbers as well (or 0).
// There are no fancy optimizations required, but still the most trivial solutions might time out. Try to find a solution which does not loop all the way up to n.

function isPrime(num) {
  let prime = ![0,1].includes(num) && num > 0
  for(var i=2; i<Math.floor(Math.sqrt(num))+1; i++) { // sqrtnum+1
      if(num % i == 0) {
          prime = false;
          break;
      }
  }
  return prime;
}

console.log(is_prime(1)); /* false */
console.log(is_prime(2)); /* true  */
console.log(is_prime(-1)); /* false */