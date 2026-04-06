using System;
using System.Collections.Generic;
using System.Text;

namespace CIS122Spr26ArraysBigOExamples
{
    public class QueueImplementation
    {
        private LinkedList<int> _values = new LinkedList<int>();

        public void Enqueue(int value)
        {
            _values.AddLast(value);
        }


        public int Dequeue()
        {
            var temp = _values.First.Value;
            _values.RemoveFirst();
            return temp;
        }


        public int Peek()
        {
            return _values.First.Value;
        }
    }
}
