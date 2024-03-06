using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzeciazanieOperatorow
{
    public class Macierz
    {
        private double[,] dane;

        public Macierz(int wiersze, int kolumny)
        {
            dane = new double[wiersze, kolumny];
        }

        public double this[int i, int j]
        {
            get { return dane[i, j]; }
            set { dane[i, j] = value; }
        }

        public int GetLength(int dimension)
        {
            return dane.GetLength(dimension);
        }

        public static Macierz operator +(Macierz macierz1, Macierz macierz2)
        {
            int rows = macierz1.dane.GetLength(0);
            int cols = macierz1.dane.GetLength(1);
            Macierz result = new Macierz(rows, cols);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = macierz1[i, j] + macierz2[i, j];
                }
            }

            return result;
        }

        public static Macierz operator -(Macierz macierz1, Macierz macierz2)
        {
            int rows = macierz1.dane.GetLength(0);
            int cols = macierz1.dane.GetLength(1);
            Macierz result = new Macierz(rows, cols);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = macierz1[i, j] - macierz2[i, j];
                }
            }

            return result;
        }

        public static Macierz operator *(Macierz macierz1, Macierz macierz2)
        {
            int rowsA = macierz1.dane.GetLength(0);
            int colsA = macierz1.dane.GetLength(1);
            int rowsB = macierz2.dane.GetLength(0);
            int colsB = macierz2.dane.GetLength(1);

            if (colsA != rowsB)
            {
                throw new ArgumentException("Liczba kolumn pierwszej macierzy musi być równa liczbie wierszy drugiej macierzy.");
            }

            Macierz result = new Macierz(rowsA, colsB);

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < colsA; k++)
                    {
                        sum += macierz1[i, k] * macierz2[k, j];
                    }
                    result[i, j] = sum;
                }
            }

            return result;
        }

        public static Macierz operator ++(Macierz macierz)
        {
            int rows = macierz.dane.GetLength(0);
            int cols = macierz.dane.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    macierz[i, j] += 2;
                }
            }

            return macierz;
        }

        public static Macierz operator --(Macierz macierz)
        {
            int rows = macierz.dane.GetLength(0);
            int cols = macierz.dane.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    macierz[i, j] -= 2;
                }
            }

            return macierz;
        }
    }
}
