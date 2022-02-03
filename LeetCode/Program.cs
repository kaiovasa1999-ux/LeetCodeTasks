namespace LeetCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var boxCapacity = int.Parse(Console.ReadLine());
            var boxes = 1;
            var amount = 0;
            var x = boxCapacity;

            Stack<int> stack = new Stack<int>(data);
            while (true)
            {
                if (!stack.Any())
                {
                    break;
                }
                amount = stack.Pop();
                if(amount < boxCapacity)
                {
                    boxCapacity -= amount;
                    continue;
                }
                if (amount >= boxCapacity)
                {
                    amount -= boxCapacity;
                    boxes++;
                    boxCapacity = x;
                    boxCapacity -= amount;
                }
               
            }
            Console.WriteLine(boxes);
        }
    }
}
