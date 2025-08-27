using System;
using System.Collections;

namespace _2Ex6._01
{
    class BitArray64 : IEnumerable<int>
    {
        private ulong values64 = 0;

        public BitArray64(ulong value) 
        {
            values64 = value;
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= 64)
                {
                    throw new IndexOutOfRangeException("Index must be between 0 and 63.");
                }

                return (int)(values64 & (1UL << index));
            }
            set
            {
                if (index < 0 || index >= 64)
                {
                    throw new IndexOutOfRangeException("Index must be between 0 and 63.");
                }

                if (value != 0 && value != 1)
                {
                    throw new ArgumentException("Bit value must be 0 or 1.");
                }

                if (value == 1) values64 |= (1UL << index);
                else values64 &= ~(1UL << index);
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override bool Equals(object obj)
        {
            if (obj is BitArray64 other)
            {
                if (values64 == other.values64)
                {
                    return true;
                }
            }
            return false;
        }

        public override int GetHashCode()
        {
            return values64.GetHashCode();
        }

        public static bool operator == (BitArray64 bitArr1, BitArray64 bitArr2)
        {
            if (ReferenceEquals(bitArr1, bitArr2)) return true;
            if(bitArr1 is null  || bitArr2 is null) return false;
            return bitArr1.values64 == bitArr2.values64;
        }

        public static bool operator != (BitArray64 bitArr1, BitArray64 bitArr2)
        {
            return !(bitArr1 == bitArr2);
        }

        
    }
}
