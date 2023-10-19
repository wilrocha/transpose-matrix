using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Transpose_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows, cols;

            int[,] matrix = new [,] {
                        {1,2,3},
                        {4,5,6},
                        {7,8,9} };
            rows = matrix.GetLength(0);
            cols = matrix.GetLength(1);

            int[,] transposed = new int[cols, rows];

            Console.WriteLine("Given matrix: ");

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    int value = matrix[i, j];
                    Console.Write(string.Concat(value, " "));

                    transposed[i, j] = matrix[j, i];
                }
                Console.WriteLine();
            }

            Console.WriteLine(Environment.NewLine + "Transpose of given matrix: ");

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    int value = transposed[i, j];
                    Console.Write(string.Concat(value, " "));
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
