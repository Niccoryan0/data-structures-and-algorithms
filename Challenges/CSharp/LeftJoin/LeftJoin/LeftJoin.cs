using System;
using System.Collections.Generic;
using HashTable;

namespace LeftJoin
{
    public class LeftJoin
    {
        /// <summary>
        /// Left Join two Hash Maps (Dictionaries)
        /// </summary>
        /// <param name="set1">First map</param>
        /// <param name="set2">Second map</param>
        /// <returns>Multidimensional string array with all values from first set and corresponding values if they exist in set2.</returns>
        public static string[,] Join(Dictionary<string, string> set1, Dictionary<string, string> set2)
        {
            string[,] result = new string[set1.Count, 3];
            int count = 0;
            foreach (var item in set1)
            {
                result[count, 0] = item.Key;
                result[count, 1] = item.Value;
                if(set2.ContainsKey(item.Key))
                {
                    result[count, 2] = set2[item.Key];
                }
                else
                {
                    result[count, 2] = null;
                }
                count++;
            }

            return result;
        }
    }
}
