namespace LeetCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var n = data[0];
            var m = data[1];

            int[,] matrix = new int[n, m];
           
            var biggestSubMatrixValue = 0;

            for (int row = 0; row < n; row++)
            {
                var rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

    
            for (int row = 0; row < n-2; row++)
            {
                for (int col = 0; col < m -2; col++)
                {
                    var sum = matrix[row, col];
                    sum += matrix[row, col + 1];
                    sum += matrix[row, col + 2];

                    sum += matrix[row + 1, col];
                    sum += matrix[row + 1, col + 1];
                    sum += matrix[row + 1, col + 2];

                    sum += matrix[row + 2, col];
                    sum += matrix[row + 2, col + 1];
                    sum += matrix[row + 2, col + 2];
                    if(sum > biggestSubMatrixValue)
                    {
                        biggestSubMatrixValue = sum;
                    }
                }

            }
            Console.WriteLine(biggestSubMatrixValue);


        }
    }
}
