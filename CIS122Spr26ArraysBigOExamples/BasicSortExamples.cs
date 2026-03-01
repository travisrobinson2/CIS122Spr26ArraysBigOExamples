using System;
using System.Collections.Generic;
using System.Text;

namespace CIS122Spr26ArraysBigOExamples
{
    public class BasicSortExamples
    {
        int[] values = new int[] { 5, 4, 2, 3, 1 };


        //O(N^2) -- go through each element of the array, for each element of the array, we go through the entire array
        public void InsertionSort()
        {
            for (int i = 1; i < values.Length; i++)
            {
                int curValue = values[i];

                int j = i - 1;
                while (j >= 0 && values[j] > curValue)
                {
                    values[j + 1] = values[j];
                    j--;
                }
                values[j+1] = curValue;
            }
        }

        //O(N^2) -- for each element in the array, cycle through all elements in the array
        public void BubbleSort()
        {
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length - 1; j++)
                {

                    if (values[j] < values[j + 1])
                    {
                        //do the swap
                        var temp = values[j];
                        values[j] = values[j + 1];
                        values[j + 1] = temp;
                    }

                }
            }
        }
    }
}
