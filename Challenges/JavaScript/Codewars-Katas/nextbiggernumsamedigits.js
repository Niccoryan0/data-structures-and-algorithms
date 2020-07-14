// Create a function that takes a positive integer and returns the next bigger number that can be formed by rearranging its digits. For example:
// 12 ==> 21
// 513 ==> 531
// 2017 ==> 2071

function nextBigger(n){
  let result = -1;
  let nums = n.toString().split('');
  for (let i = nums.length - 1; i >= 0; --i) {
    if (nums[i] < nums[i + 1]) {
      let rightPartNums = nums.splice(i + 1).sort();
      for (let j = 0; j < rightPartNums.length; ++j) {
        if (rightPartNums[j] > nums[i]) {
          nums[i] = rightPartNums[j] - nums[i];
          rightPartNums[j] = rightPartNums[j] - nums[i];
          nums[i] = rightPartNums[j] + nums[i];
          result = parseInt(nums.concat(rightPartNums).join(''), 10);
          i = 0;
          break;
        }
      }
    }
  }
  return result;
}

console.log(nextBigger(12))   // returns 21
console.log(nextBigger(513))  // returns 531
console.log(nextBigger(2017)) // returns 2071

console.log(nextBigger(9))   // returns -1
console.log(nextBigger(111)) // returns -1
console.log(nextBigger(531)) // returns -1