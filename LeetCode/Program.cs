namespace LeetCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var n = sizes[0];
            var m = sizes[1];
            char[,] matrix = new char[n, m];
            var PlayerRow = 0;
            var PlayerCol = 0;

            bool isWinner = false;
            bool isDead = false;


            for (int row = 0; row < n; row++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'P')
                    {
                        PlayerRow = row;
                        PlayerCol = col;
                    }
                }

            }

            var dircations = Console.ReadLine();

            foreach (var direction in dircations)
            {
                var newPlayerRow = PlayerRow;
                var newPlayerCol = PlayerCol;
                List<int[]> B_Coordinates = GetBunniesCoodrinates(matrix);
                if (direction == 'U')
                {
                    newPlayerCol--;
                }
                if (direction == 'D')
                {
                    newPlayerRow++;
                }
                if (direction == 'L')
                {
                    newPlayerCol--;
                }
                if (direction == 'R')
                {
                    newPlayerCol++;
                }

                if (!IsValidCell(newPlayerRow, newPlayerCol, n, m))
                {
                    isWinner = true;
                  
                    matrix[PlayerRow, PlayerCol] = '.';
                    if (isWinner == true)
                    {
                        Console.WriteLine($"Winner {PlayerRow} {PlayerCol}");
                        break;
                    }

                }
                else if (matrix[newPlayerRow, newPlayerCol] == '.')
                {
                  
                    matrix[PlayerRow, PlayerCol] = '.';
                    matrix[newPlayerRow, newPlayerCol] = 'P';
                    PlayerRow = newPlayerRow;
                    PlayerCol = newPlayerCol;
                    if (isWinner == true)
                    {
                        Console.WriteLine($"Winner {PlayerRow} {PlayerCol}");
                        break;
                    }

                }
                else if (matrix[newPlayerRow, newPlayerCol] == 'B')
                {
                    isDead = true;
                   
                    matrix[PlayerRow, PlayerCol] = '.';
                    PlayerRow = newPlayerRow;
                    PlayerCol = newPlayerCol;
                    if (isDead)
                    {
                        Console.WriteLine($"Dead: {PlayerRow}{PlayerCol}");
                    }
                }
              
                SpreadBunnie(B_Coordinates, matrix);

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        Console.Write(matrix[row, col]);
                    }
                    Console.WriteLine();
                }
            }
        }

        private static void SpreadBunnie(List<int[]> b_Coordinates, char[,] matrix)
        {
            foreach (int[] b_cordinates in b_Coordinates)
            {
                int row = b_cordinates[0];
                int col = b_cordinates[1];
                if (IsValidCell(row - 1, col, matrix.GetLength(0), matrix.GetLength(1)))
                {
                    matrix[row, col] = 'B';
                }
                if (IsValidCell(row + 1, col, matrix.GetLength(0), matrix.GetLength(1)))
                {
                    matrix[row, col] = 'B';
                }
                if (IsValidCell(row, col +1, matrix.GetLength(0), matrix.GetLength(1)))
                {
                    matrix[row, col] = 'B';
                }
                if (IsValidCell(row , col - 1, matrix.GetLength(0), matrix.GetLength(1)))
                {
                    matrix[row, col] = 'B';
                }
            }
        }

        private static List<int[]> GetBunniesCoodrinates(char[,] matrix)
        {
            List<int[]> bunniesCoordinates = new List<int[]>();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        bunniesCoordinates.Add(new int[] { row, col });
                    }
                }
            }
            return bunniesCoordinates;
        }

        private static bool IsValidCell(int row, int col, int n, int m)
        {
            return row >= 0 && row < n && col >= 0 && col < m;
        }
    }
}
