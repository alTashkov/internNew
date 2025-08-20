using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _4._02
{
    [VersionAttribute(1, 0)]
    class Matrix<T> where T : INumber<T>
    {
        private int Rows { get; set; }
        private int Columns { get; set; }
        T[,] matrix;
        public Matrix(int rows, int columns)
        {
            this.Rows = rows;
            this.Columns = columns;
            matrix = new T[Rows, Columns];
        }

        public T this[int indexRows, int indexCols]
        {
            get
            {
                if (indexRows > Rows || indexCols > Columns)
                {
                    throw new ArgumentOutOfRangeException("Index is out of bounds!");
                }
                return matrix[indexRows, indexCols];
            }
            set
            {
                if (indexRows > Rows || indexCols > Columns)
                {
                    throw new ArgumentOutOfRangeException("Index is out of bounds!");
                }
                matrix[indexRows, indexCols] = value;
            }
        }

        public static Matrix<T> operator + (Matrix<T> left, Matrix<T> right)
        {
            if (left.Rows != right.Rows || left.Columns != right.Columns)
            {
                throw new ArgumentException("Sizes of matrices have to be equal!");
            }
            Matrix<T> added = new Matrix<T>(left.Rows, right.Columns);

            for (int i = 0; i < left.Rows; i++)
            {
                for (int j = 0; j < right.Rows; j++)
                {
                    added.matrix[i, j] = left.matrix[i, j] + right.matrix[i, j];
                }
            }

            return added;
        }

        public static Matrix<T> operator - (Matrix<T> left, Matrix<T> right)
        {
            if (left.Rows != right.Rows || left.Columns != right.Columns)
            {
                throw new ArgumentException("Sizes of matrices have to be equal!");
            }
            Matrix<T> subtracted = new Matrix<T>(left.Rows, right.Columns);

            for (int i = 0; i < left.Rows; i++)
            {
                for (int j = 0; j < right.Rows; j++)
                {
                    subtracted.matrix[i, j] = left.matrix[i, j] - right.matrix[i, j];
                }
            }

            return subtracted;
        }
        public static Matrix<T> operator * (Matrix<T> left, Matrix<T> right)
        {
            if (left.Rows != right.Rows || left.Columns != right.Columns)
            {
                throw new ArgumentException("Sizes of matrices have to be equal!");
            }
            Matrix<T> multiplied = new Matrix<T>(left.Rows, right.Columns);
            for (int i = 0; i < left.Rows; i++)
            {
                for (int j = 0; j < right.Columns; j++)
                {
                    for (int k = 0; k < left.Columns; k++)
                    {
                        multiplied.matrix[i, j] += left.matrix[i, k] * right.matrix[k, j];
                    }
                }
            }
            return multiplied;
        }
        
        public static bool operator true (Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    if (!(matrix[i,j].Equals(default(T))))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            return !(matrix ? true : false);
        }

        public void PrintVersion()
        {
            Type type = typeof(Matrix<T>);
            if (type.GetCustomAttributes(typeof(VersionAttribute), false) is VersionAttribute[] attrs && attrs.Length > 0)
            {
                Console.WriteLine($"Matrix<{typeof(T).Name}> Version: {attrs[0]}");
            }
            else
            {
                Console.WriteLine("Version not found.");
            }
        }
    }
}
