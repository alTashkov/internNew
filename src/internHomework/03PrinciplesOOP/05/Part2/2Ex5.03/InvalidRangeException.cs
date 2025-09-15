using System;

namespace _2Ex5._03
{
    class InvalidRangeException<T> : Exception where T : IComparable<T>
    {
        public InvalidRangeException(T start, T end)
            : base(message: $"Invalid Range!. One or both bounds of [{start.ToString()} ; {end.ToString()}] are outside of given range!")
        {
        }
    }
}
