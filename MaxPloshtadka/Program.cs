using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxPloshtadka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix ={
               { 1, 2, 8, 3, 4 },
               { 5, 6, 7, 8, 9 },
               { 2, 8, 3, 4, 5},
               { 7, 5, 1, 0, 2 },
               { 1, 8, 9, 9, 3 },

            };

            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int sum =matrix[row, col] + matrix[row, col + 1] +
                          matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }
            Console.WriteLine($"{matrix[bestRow, bestCol]} , {matrix[bestRow, bestCol + 1]}");
            Console.WriteLine($"{matrix[bestRow + 1, bestCol]} , {matrix[bestRow + 1, bestCol + 1]}");
        }
    }
}
