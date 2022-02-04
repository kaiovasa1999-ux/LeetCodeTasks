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
            for (int row = 0; row < n; row++)
            {
                int[] matrixRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = matrixRow[col];
                }
            }

            while (true)
            {
                var rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                var command = rowData[0];

                if(command == "END")
                {
                    break;
                }
                if (command == "swap")
                {
                    var r1 = int.Parse(rowData[1]);
                    var c1 = int.Parse(rowData[2]);
                    var r2 = int.Parse(rowData[3]);
                    var c2 = int.Parse(rowData[4]);

                    if(r1 > n || r1 > m
                        || r2 > n || r2 > m
                        || c1 > n || c1 > m
                        || c2 > n || c1 > m)
                    {
                        Console.WriteLine("INvalid input");
                    }
                    else
                    {
                        var x = matrix[r1, c1];
                        matrix[r1, c1] = matrix[r2, c2];
                        matrix[r2, c2] = x;
                        for (int row = 0; row < n; row++)
                        {
                            for (int col = 0; col < m; col++)
                            {
                                Console.WriteLine(matrix[row, col]);
                                Console.Write("");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine(command);
                }
                
            }
          
        }
    }
}
