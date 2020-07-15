// What is an anagram? Well, two words are anagrams of each other if they both contain the same letters. For example:

// 'abba' & 'baab' == true

// 'abba' & 'bbaa' == true

// 'abba' & 'abbba' == false

// 'abba' & 'abca' == false
// Write a function that will find all the anagrams of a word from a list. You will be given two inputs a word and an array with words. You should return an array of all the anagrams or an empty array if there are none. For example:

// anagrams('abba', ['aabb', 'abcd', 'bbaa', 'dada']) => ['aabb', 'bbaa']

// anagrams('racer', ['crazer', 'carer', 'racar', 'caers', 'racer']) => ['carer', 'racer']

// anagrams('laser', ['lazing', 'lazy',  'lacer']) => []

using System;
using System.Collections.Generic;
using System.Linq;
public static class Kata
{
  public static List<string> Anagrams(string word, List<string> words)
  {
    // My solution:
    List<string> result = new List<string>();  
    string wordSort = String.Concat(word.OrderBy(x => x));
    foreach (string item in words){
      string itemSort = String.Concat(item.OrderBy(x => x));
      if (wordSort == itemSort){
        result.Add(item);
      }
    }
    return result;



    // Top Solution, user: kleidemos
    // var pattern = word.OrderBy(p => p).ToArray();
    // return words.Where(item => item.OrderBy(p => p).SequenceEqual(pattern)).ToList();


  }
}