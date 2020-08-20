using System;
using System.Collections.Generic;
using HashTable;

namespace LeftJoin
{
    public class LeftJoin
    {
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
