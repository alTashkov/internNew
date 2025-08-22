using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Ex5._03
{
    class InvalidRangeException<T> : Exception where T : IComparable<T>
    {
        private string _message;

        public InvalidRangeException(T start, T end)
        {
            _message = $"Invalid Range!. Start value {start.ToString()} cannot be greater than end value {end.ToString()}!";
        }

        public override string Message {
            get { return _message; }
        }
    }
}
