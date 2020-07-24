// Write a function that takes an integer as input, and returns the number of bits that are equal to one in the binary representation of that number. You can guarantee that input is non-negative.

var countBits = function(n) {
  return (n).toString(2).split('').reduce((acc,val) => (val==='1') ? acc+1:acc ,0)
};

console.log(countBits(1234)); // returns 5 