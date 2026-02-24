using System;
using System.Collections.Generic;
using System.Text;

namespace CIS122Spr26ArraysBigOExamples
{
    public class SearchExamples
    {
        //O(N) -- Linear search, go through each element until we find target
        //As array size increases, time taken increases at the same rate
        //If target not found, return -1 since that is not a valid array index
        public static int FindFirst(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }


        //O(log N) -- Binary search, repeatedly cut search space in half until we find target
        // As array size increases, time taken increases at a much slower rate than linear search
        //Return index of target if found, otherwise return -1 as -1 is not a valid array index
        public static int BinarySearch(int[] arr, int target)
        {
            /*
             * Begin by determining the initial search space
             */
            int left = 0;
            int right = arr.Length - 1;

            /*
             * Continue for as long as the search space is valid
             */
            while (left <= right)
            {
                /*
                 * Determine middle location
                 */
                int middle = left + (right - left) / 2;

                /*
                 * Perform comparison
                 * If middle is target, return index
                 * Otherwise narrow down search, and repeat
                 */
                if (arr[middle] == target)
                {
                    return middle;
                }

                if (arr[middle] > target)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }
            /*
             * If target not found, return -1
             */
            return -1;
        }
    }
}