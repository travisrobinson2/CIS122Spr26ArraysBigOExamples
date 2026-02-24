using System;
using System.Collections.Generic;
using System.Text;

namespace CIS122Spr26ArraysBigOExamples
{
    public class DynamicArrayExample
    {
        private Student[] data = new Student[4];

        private int _count = 0;

        public int Size { get { return _count; } }

        //Best Case -- O(1), not at capacity, just assigning variables take constant time
        //Worst Case -- O(N), have to resize due to array at capacity
        //Average Case -- O(1) - amortize to best case -- vast majority of the time, best case
        //        will be the one applied
        public void Add(Student newStudent)
        {
            if (_count == data.Length)
            {
                Resize();
            }
            data[_count] = newStudent;
            _count++;
        }

        //O(N) -- looping through all elements, as input increases
        //time spent increases proportionally
        private void Resize()
        {
            Student[] newData = new Student[data.Length * 2]; //4 goes to 8, 8 goes to 16, 16 to 32, 32 to 64....

            for (int i = 0; i < data.Length; i++) {
                {
                    newData[i] = data[i];
                }
                data = newData;
            }
        }

        //O(N) -- looping over array increases linearly
        //looping twice is O(2N) - drop 2 as N is largest factor
        public bool Remove(Student student)
        {

            int indexToRemove = -1;
            for (int i = 0; i < _count; i++)
            {
                if (data[i].Equals(student))
                {
                    indexToRemove = i;
                    break;
                }
            }

            if (indexToRemove != -1)
            {
                for (int i = indexToRemove; i < _count; i++)
                {
                    data[i] = data[i + 1];
                }
                _count--;
                return true;
            }

            return false;
        }

        //O(1) -- all operations take constant time
        public void Clear()
        {
            Student[] newData = new Student[4];
            data = newData;
            _count = 0;
        }

    }



    public class Student
    {
        public int Id { get; }
        public string Name { get; }

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}