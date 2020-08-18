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
            List<string> tracker = new List<string>();
            var removeCommas = Regex.Replace(str, @"[^\w\s]", "");
            foreach (string word in removeCommas.Split(' '))
            {
                // Can be done with a for loop checking each item if tracker if it equals the word, contains does the same under the hood
                if (tracker.Contains(word.ToLower()))
                {
                    return word;
                }
                tracker.Add(word.ToLower());
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
