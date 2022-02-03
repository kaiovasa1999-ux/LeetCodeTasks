namespace LeetCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = data[0];
            int s = data[1];
            int x = data[2];
            int[] nummbersInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> numbers = new Stack<int>(nummbersInput);

            //for (int i = 0; i < n; i++)
            //{
            //    numbers.Push(nummbersInput[i]);
            //}
            while (true)
            {
                if (s >= numbers.Count)
                {
                    Console.WriteLine(0);
                    break;
                }
                for (int i = 0; i < s; i++)
                {
                    numbers.Pop();
                }

                if (numbers.Contains(x))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(numbers.Min());
                }
            }
            //Console.WriteLine(string.Join(", ", numbers));
         
        }
    }
}
