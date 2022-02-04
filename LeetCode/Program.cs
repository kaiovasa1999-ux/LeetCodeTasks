namespace LeetCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using LeetCode.Matrix;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var sum1 = 0;
            var sum2 = 0;
            int[,] matrix = new int[n, n];
            for (int row = 0; row < n; row++)
            {
                int[] rowData = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (row == col)
                    {
                        sum1 += matrix[row, col];
                    }
                }
            }

            for (int r = 0; r < n; r++)
            {
                for (int c = n - 1; c >= 0; c--)
                {

                    sum2 += matrix[r, c];
                    r++;
                }
            }
            var res = Math.Abs(sum1 - sum2);
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(res);


        }
    }
}
