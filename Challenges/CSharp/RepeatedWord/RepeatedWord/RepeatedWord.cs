using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using HashTable;

namespace RepeatedWord
{
    public class RepeatedWord
    {
        /// <summary>
        /// Find and return the first repeated word in a string, or an empty string if inapplicable
        /// </summary>
        /// <param name="str">String to be searched for repeats</param>
        /// <returns>First repeated word or an empty string</returns>
        public static string FindRepeat(string str)
        {
            HashSet<string> set = new HashSet<string>();
            var removePunc = Regex.Replace(str, @"[^\w\s]", "");
            foreach (string word in removePunc.Split(' '))
            {
                // Can be done with a for loop checking each item if tracker if it equals the word, contains does the same under the hood
                if (!set.Add(word.ToLower()))
                {
                    return word;
                }
            }
            return "";
        }

        /// <summary>
        /// Count and order the total number of times each word occurs in a given string, then sort by count
        /// </summary>
        /// <param name="str">String to be counter and parsed</param>
        /// <returns>List of words sorted by occurence in the string</returns>
        public static List<string> CountAndOrderWords(string str)
        {
            var removeCommas = Regex.Replace(str, ",", string.Empty);
            HashSet<string> set = new HashSet<string>();
            HashSet<int> countset = new HashSet<int>();
            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string word in removeCommas.Split(' '))
            {
                if (counts.TryGetValue(word, out int count))
                {
                    counts[word] = count++;
                }
                else
                {
                    counts.Add(word, 0);
                }
            }
            var result = counts.OrderBy(x => x.Value).ToDictionary(key => key.Key, value => value.Value);
            return result.Keys.ToList();
        }
    }
}
