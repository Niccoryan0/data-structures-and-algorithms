// Description
// Middle Earth is about to go to war. The forces of good will have many battles with the forces of evil. Different races will certainly be involved. Each race has a certain worth when battling against others. On the side of good we have the following races, with their associated worth:

// Hobbits: 1
// Men: 2
// Elves: 3
// Dwarves: 3
// Eagles: 4
// Wizards: 10
// On the side of evil we have:

// Orcs: 1
// Men: 2
// Wargs: 2
// Goblins: 2
// Uruk Hai: 3
// Trolls: 5
// Wizards: 10
// Although weather, location, supplies and valor play a part in any battle, if you add up the worth of the side of good and compare it with the worth of the side of evil, the side with the larger worth will tend to win.

// Thus, given the count of each of the races on the side of good, followed by the count of each of the races on the side of evil, determine which side wins.

// Input:
// The function will be given two parameters. Each parameter will be a string of multiple integers separated by a single space. Each string will contain the count of each race on the side of good and evil.

// The first parameter will contain the count of each race on the side of good in the following order:

// Hobbits, Men, Elves, Dwarves, Eagles, Wizards.
// The second parameter will contain the count of each race on the side of evil in the following order:

// Orcs, Men, Wargs, Goblins, Uruk Hai, Trolls, Wizards.
// All values are non-negative integers. The resulting sum of the worth for each side will not exceed the limit of a 32-bit integer.

// Output:
// Return "Battle Result: Good triumphs over Evil" if good wins, "Battle Result: Evil eradicates all trace of Good" if evil wins, or "Battle Result: No victor on this battle field" if it ends in a tie.

// Better method inspired by top "clever" answer

using System;
using System.Linq;
public class Kata
{
  public static string GoodVsEvil(string good, string evil)
  {
    var goodGuys = new[] { 1, 2, 3, 3, 4, 10 };
    var evilGuys = new[] { 1, 2, 2, 2, 3, 5, 10 };
    // Select does the parsing to make them integers
    // Zip combines the two lists to allow for iterating through each simultaneously, num represents each integer in the split array we are creating, and val is each integer in the arrays above.
    var goodTotal = good.Split(' ').Select(int.Parse).Zip(goodGuys, (num, val) => num * val).Sum();
    var evilTotal = evil.Split(' ').Select(int.Parse).Zip(evilGuys, (num, val) => num * val).Sum();
    return (goodTotal > evilTotal) ? "Battle Result: Good triumphs over Evil" : ((goodTotal == evilTotal) ? "Battle Result: No victor on this battle field" : "Battle Result: Evil eradicates all trace of Good");
  }
}

// My original method, more archaic:
/* 
using System;

public class Kata
{
  public static string GoodVsEvil(string good, string evil)
  {
    int[] goodGuys = {1,2,3,3,4,10};
    int[] evilGuys = {1,2,2,2,3,5,10};
    int goodTotal = 0;
    int evilTotal = 0;

    for (var i = 0; i < good.Split(" ").Length; i++){
      for(var j = 0; j < int.Parse(good.Split(" ")[i]); j++){
        goodTotal += goodGuys[i];
      }
    }
 
    for (var i = 0; i < evil.Split(" ").Length; i++){
      for(var j = 0; j < int.Parse(evil.Split(" ")[i]); j++){
        evilTotal += evilGuys[i];
      }
    }
    
    return (goodTotal > evilTotal) ? "Battle Result: Good triumphs over Evil" : ((goodTotal == evilTotal) ? "Battle Result: No victor on this battle field" : "Battle Result: Evil eradicates all trace of Good");

  }
}
*/

// Kata.GoodVsEvil("1 1 1 1 1 1", "1 1 1 1 1 1 1")
// Kata.GoodVsEvil("0 0 0 0 0 10", "0 1 1 1 1 0 0")
// Kata.GoodVsEvil("1 0 0 0 0 0", "1 0 0 0 0 0 0")