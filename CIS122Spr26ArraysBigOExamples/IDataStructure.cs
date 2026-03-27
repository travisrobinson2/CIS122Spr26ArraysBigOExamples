using System;
using System.Collections.Generic;
using System.Text;

namespace CIS122Spr26ArraysBigOExamples
{
    public interface IDataStructure
    {
        int Count { get; }

        void Add(int value);
        int FindFirst(int targetValue);
        void Sort();
    }
}
