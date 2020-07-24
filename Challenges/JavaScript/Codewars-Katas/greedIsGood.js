// Greed is a dice game played with five six-sided dice. Your mission, should you choose to accept it, is to score a throw according to these rules. You will always be given an array with five six-sided dice values.

//  Three 1's => 1000 points
//  Three 6's =>  600 points
//  Three 5's =>  500 points
//  Three 4's =>  400 points
//  Three 3's =>  300 points
//  Three 2's =>  200 points
//  One   1   =>  100 points
//  One   5   =>   50 point
// A single die can only be counted once in each roll. For example, a "5" can only count as part of a triplet (contributing to the 500 points) or as a single 50 points, but not both in the same roll.

// Example scoring

//  Throw       Score
//  ---------   ------------------
//  5 1 3 4 1   50 + 2 * 100 = 250
//  1 1 1 3 1   1000 + 100 = 1100
//  2 4 4 5 4   400 + 50 = 450
// In some languages, it is possible to mutate the input to the function. This is something that you should never do. If you mutate the input, you will not be able to pass all the tests.

function score( dice ) {
  const diceCounts = {};
  let total = 0;
  for (let i = 0; i < dice.length; i++) {
    const die = dice[i];
    diceCounts[die] = diceCounts[die] ? diceCounts[die] + 1 : 1;
  }
  for (i = 1; i <= 6; i++){
    let currCount = diceCounts[i]
    if (currCount >= 3) {
      i === 1 ? total+=(1000) : total+=(i*100);
      currCount-=3
    }
    while(currCount) {
      if(i === 1 && currCount > 0) total+=100
      if(i === 5 && currCount > 0) total+=50
      currCount -=1
    }
  }
  return total;
}


console.log(score( [2, 3, 4, 6, 2] )); // return 0
console.log(score( [2, 2, 2, 3, 3] )); // return 200
console.log(score( [2, 4, 4, 5, 4] )); // return 450

