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
            var s = data[1];
            var x = data[2];
            var numberdata = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> q = new Queue<int>(numberdata);


            while (true)
            {
                if (q.Count() <= s)
                {
                    Console.WriteLine(0);
                    break;
                }
                for (int i = 0; i < s; i++)
                {
                    q.Dequeue();
                }
                if (q.Contains(x))
                {
                    Console.WriteLine(true);
                }

                else
                {
                    Console.WriteLine(q.Min());
                }
            }
          
           
        }
    }
}
