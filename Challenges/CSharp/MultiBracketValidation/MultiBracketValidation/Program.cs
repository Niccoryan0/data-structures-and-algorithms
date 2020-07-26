using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MultiBracketValidation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        /// <summary>
        /// Takes in a string and validates if all the brackets are matched up correctly
        /// </summary>
        /// <param name="input">String to be checked</param>
        /// <returns>True or false for if brackets are matched</returns>
        public static bool MultiBracketValidator(string input)
        {
            List<char> storage = new List<char>();
            char[] left = new char[] { '(', '{', '[' };
            char[] right = new char[] { ')', '}', ']' };

            foreach (char item in input)
            {
                if(Array.Exists(left, x => x == item))
                {
                    storage.Add(right[Array.IndexOf(left, item)]);
                }
                else if (Array.Exists(right, x => x == item))
                {
                    int len = storage.Count-1;
                    if(storage[len] == item)
                    {
                        storage.RemoveAt(len);
                    } else
                    {
                        return false;
                    }
                }
            }
            if (storage.Any())
            {
                return false;
            }

            return true;
        }
    }
}
