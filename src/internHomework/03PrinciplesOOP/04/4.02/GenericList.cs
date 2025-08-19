using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _4._02
{
    class GenericList<T> : List<T>
    {
        private T[] array;
        private int currentSize;
        private int count = 0;
        public void AddElement(T element)
        {
            if (count + 1 > array.Length)
            {
                AutoGrow();
            }
            array[count++] = element;
        }
        public void RemoveByIndex(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new ArgumentException("Index is out of bounds!");
            }

            for (int i = index; i < count - 1; i++)
                array[i] = array[i + 1];

            array[--count] = default(T);
        }

        public void InsertAtIndex(int index, T element)
        {
            if(count + 1 > array.Length)
            {
                AutoGrow();
            }
            if (index < 0 || index >= count)
            {
                throw new ArgumentException("Index is out of bounds!");
            }

            array[index] = element;
            count++;
        }

        public void Clear()
        {
            array = new T[currentSize];
        }

        public int FindIndexByValue(T value)
        {
            if (!array.Contains(value))
            {
                throw new ArgumentException("Given value was not found in the list!");
            }

            int index = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i].Equals(value))
                {
                    return i;
                }
            }

            return -1;
        }

        public T this[int index]
        {
            get {
                if (index < 0 || index >= count)
                    throw new ArgumentOutOfRangeException();
                return array[index]; 
            }
            set {
                if (index < 0 || index >= count)
                    throw new ArgumentOutOfRangeException();
                array[index] = value; 
            }
        }
        private void AutoGrow()
        {
            int newSize = array.Length * 2;
            T[] newArray = new T[newSize];
            Array.Copy(array, newArray, array.Length);
            array = newArray;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (T element in array)
            {
                sb.Append(element);
            }
            return sb.ToString();
        }

        public T Min<TComparable>() where TComparable : T, IComparable<TComparable>
        {
            if (count == 0) throw new InvalidOperationException("List is empty");
            TComparable min = (TComparable)array[0];
            for (int i = 1; i < count; i++)
            {
                TComparable current = (TComparable)array[i];
                if (current.CompareTo(min) < 0)
                    min = current;
            }
            return min;
        }

        public T Max<TComparable>() where TComparable : T, IComparable<TComparable>
        {
            if (count == 0) throw new InvalidOperationException("List is empty");

            TComparable max = (TComparable)array[0];
            for (int i = 1; i < count; i++)
            {
                TComparable current = (TComparable)array[i];
                if (current.CompareTo(max) > 0)
                    max = current;
            }
            return max;
        }
    }
}
