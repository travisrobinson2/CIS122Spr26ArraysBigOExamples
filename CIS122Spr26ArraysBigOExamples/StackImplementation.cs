using System;
using System.Collections.Generic;
using System.Text;

namespace CIS122Spr26ArraysBigOExamples
{
    public class StackImplementation
    {
        private LinkedList<int> _values  = new LinkedList<int>();

        public void Push(int value)
        {
            _values.AddFirst(value);
        }

        public int Peek()
        {
            return _values.First.Value;
        }

        public int Pop()
        {
            var temp = _values.First.Value;
            _values.RemoveFirst();
            return temp;
        }
    }
}
