using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RepeatedWord
{
    public class RepeatedWord
    {
        public static string FindRepeat(string str)
        {
            List<string> tracker = new List<string>();
            var removeCommas = Regex.Replace(str, ",", string.Empty);
            foreach (string word in removeCommas.Split(' '))
            {
                if (tracker.Contains(word.ToLower()))
                {
                    return word;
                }
                tracker.Add(word.ToLower());
            }
            return "";
        }


    }
}
