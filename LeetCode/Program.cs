namespace LeetCode
{
    using System;
    using System.Collections.Generic;
    using LeetCode.PrentesesGeneration;

    class Program
    {
        static void Main(string[] args)
        {
            var x = new ListMerger();
            var l1 = new List<int>();
            var l2 = new List<int>();
          
            l1.Add(1);
            l1.Add(2);
            l1.Add(3);
            l1.Add(4);
            l1.Add(5);
            l1.Add(8);
            l2.Add(3);
            l2.Add(31);
            l2.Add(6);
            l2.Add(2);
            l2.Add(7);

            var res = "";
            foreach (var item in x.MergeTwoLists(l1, l2))
            {
                res += item + ", ";
            }

            Console.WriteLine(res);

        }
    }
}
