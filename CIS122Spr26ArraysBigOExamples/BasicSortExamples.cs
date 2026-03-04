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

        //O(N log N) -- log N from dividing the array in half each time, N from merging the two halves together
        public void MergeSort(int[] values, int left, int right)
        {
            //Merge sort on left side of array
            //Merge sort on right side of array
            //Merge the two sorted halves together
            int middle = left + (right - left) / 2;
            MergeSort(values, left, middle);
            MergeSort(values, middle + 1, right);
            Merge(values, left, middle, right);
        }

        private void Merge(int[] values, int left, int middle, int right)
        {
            //Copy the data into temp arrays
            int leftArrLength = middle - left + 1;
            int rightArrLength = right - middle;
            int[] leftArray = new int[leftArrLength];
            int[] rightArray = new int[rightArrLength];

            for (int idx = 0; idx < leftArrLength; idx++)
            {
                leftArray[idx] = values[left + idx];
            }
            for (int idx = 0; idx < rightArrLength; idx++)
            {
                rightArray[idx] = values[middle + 1 + idx];
            }


            //Merge the two sorted halves together via value comparison
            int i = 0, j = 0, k = left;

            while (i < leftArrLength && j < rightArrLength)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    values[k] = leftArray[i];
                    i++;
                }
                else
                {
                    values[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            //Copy what's left of the two sub arrays into the original array
            while (i < leftArrLength)
            {
                values[k] = leftArray[i];
                i++;
                k++;
            }
            while (j < rightArrLength)
            {
                values[k] = rightArray[j];
                j++;
                k++;
            }
        }
    }
}
