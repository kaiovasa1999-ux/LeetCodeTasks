namespace LeetCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            var res = string.Empty;
            for (
                int i = 0; i < x; i++)
            {
                int[] data = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                var function = data[0];
                if(function == 1)
                {
                    var number = data[1];
                    stack.Push(number);
                }
                if(!stack.Any() && function == 2)
                {
                    continue;
                }
                if(function == 2)
                {
                    stack.Pop();
                }
                if(function == 3)
                {
                    //Console.WriteLine(stack.Max());
                    res += ", " + stack.Max().ToString();
                }
                else
                {
                    //Console.WriteLine(stack.Min());
                    res +=", " + stack.Min().ToString();
                }
            }
            Console.WriteLine(res);
            Console.WriteLine(string.Join(", ", stack));

        }
    }
}
