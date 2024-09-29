using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6._4
{
    internal class Rotated
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 } };

            Console.WriteLine("Matrix:");
            PrintMatrix(matrix);
            
            int[][] rotated = Rotate(matrix);
            Console.WriteLine("Rotated Matrix");
            PrintMatrix(rotated);


        }
        static int[][] Rotate(int[][] matrix)
        {
            int n = matrix.Length;
            int[][] rotated = new int[n][];
            for (int i = 0; i < n; i++)
            {
                rotated[i] = new int[n];
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    rotated[j][n - i - 1] = matrix[i][j];
                }
            }
            return rotated;
        }

        static void PrintMatrix(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
