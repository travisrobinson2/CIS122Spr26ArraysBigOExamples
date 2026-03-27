using System;
using System.Collections.Generic;
using System.Text;

namespace CIS122Spr26ArraysBigOExamples
{
    public class DynamicArrayReview : IDataStructure
    {

        private int[] _values = new int[4];

        public int Count { get; private set; } = 0;

        private void Resize()
        {
            int[] newValues = new int[_values.Length * 2];

            for(int i = 0; i < _values.Length; i++)
            {
                newValues[i] = _values[i];
            }
            _values = newValues;
        }

        //O(1) -- usually, just set a value in the array, increment counter, each is a constant time action
        //O(N) -- when we do resize, since have to process all elements of the array
        //O(1) amortized -- most of the time, don't have to do resize, so just O(1), but every so often, have to do O(N) work, so average is O(1)
        public void Add(int value)
        {
            if(Count == _values.Length)
            {
                Resize();
            }
            _values[Count] = value;
            Count++;
        }


        //O(N) - as array increases, time spent processing increases proportionally
        public void Remove(int targetIndex)
        {
            for (int i = targetIndex; i < Count - 1; i++)
            {
                _values[i] = _values[i + 1];
            }
            Count--;
        }

        public void Sort()
        {
            //Bubble Sort
            //O(N^2) -- for each element in array, have to process all other elements (see nested for loop)
            //for (int i = 0; i < Count - 1; i++)
            //{
            //    for (int j = 0; j < Count - i - 1; j++)
            //    {
            //        if (_values[j] < _values[j + 1])
            //        {
            //            int temp = _values[j];
            //            _values[j] = _values[j + 1];
            //            _values[j + 1] = temp;
            //        }
            //    }
            //}

            //Merge Sort
            //O(N log N) -- log N comes from splitting array at each step
            // -- N comes from processing each element of the array at each step (see merge method)
            //O(N log N) is combination
            MergeSort(_values, 0, Count - 1);
        }

        //O(N) -- looking at each element until finding the target value, see single for loop
        public int FindFirst(int targetValue)
        {

            for (int i = 0; i < Count; i++)
            {
                if (_values[i] == targetValue)
                {
                    return i;
                }
            }
            return -1;
        }


        private void MergeSort(int[] values, int left, int right)
        {
            if(left < right)
            {
                //int middle = (left + right) / 2;
                int middle = left + (right - left) / 2;
                MergeSort(values, left, middle);
                MergeSort(values, middle + 1, right);
                Merge(values, left, middle, right);
            }
        }
        private void Merge(int[] values, int left, int middle, int right)
        {
            //create new arrays
            int leftSize = middle - left + 1;
            int rightSize = right - middle;
            int [] leftArray = new int[leftSize];
            int [] rightArray = new int[rightSize];

            //copy left, right values into new arrays
            for (int i = 0; i < leftSize; i++)
            {
                leftArray[i] = values[left + i];
            }
            for (int i = 0; i < rightSize; i++)
            {
                rightArray[i] = values[middle + 1 + i];
            }

            //merge left/right subarrays back together
            int i, j, k;
            i = j = k = 0;
            while (i < leftSize && j < rightSize)
            {
                if (leftArray[i] >= rightArray[j])
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

            //copy leftover data into array
            while (i < leftSize)
            {
                values[k] = leftArray[i];
                i++;
                k++;
            }
            while (j < rightSize)
            {
                values[k] = rightArray[j];
                j++;
                k++;
            }
        }
    }
}
