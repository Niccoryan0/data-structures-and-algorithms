using System;

namespace ArrayShift
{
    public class Program
    {
        /// <summary>
        /// Calls the InsertShiftArray twice with example values.
        /// </summary>
        public static void Main(string[] args)
        {
            InsertShiftArray(new int[] { 2, 4, 6, 8 }, 5);
            InsertShiftArray(new int[] { 4, 8, 15, 23, 42 }, 16);
        }
        /// <summary>
        /// Adds an item to the center position of an array, or one index above center for even arrays.
        /// </summary>
        /// <param name="arr"> Inital array to be modified</param>
        /// <param name="number">Number to be added</param>
        /// <returns>New array with the number added to the center of the input array</returns>
        public static int[] InsertShiftArray(int[] arr, int number)
        {
            int index = (arr.Length+1) / 2;
            int[] result = new int[arr.Length+1];
            result[index] = number;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < index)
                {
                    result[i] = arr[i];
                } else if (i >= index)
                {
                    result[i + 1] = arr[i];
                }
            }
            return result;
        }
    }
}
