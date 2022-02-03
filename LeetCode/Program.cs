namespace LeetCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            var orders = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(orders);
            Console.WriteLine(queue.Max());

            while (true)
            {
                var x = queue.Dequeue();
                if (food < x)
                {
                    Console.WriteLine($"not food {food} for order " + x);
                    break;
                }
                if(queue.Count() == 0)
                {
                    break;
                }
                food -= x;
                if (food > 0 && queue.Count() == 0)
                {
                    Console.WriteLine("done");
                }

            }

        }
    }
}
