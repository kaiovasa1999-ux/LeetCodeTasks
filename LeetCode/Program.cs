namespace LeetCode
{
    using System;
    using LeetCode.ArrayConcatenation;

    class Program
    {
        static void Main(string[] args)
        {
            var x = new ArrayConcatenationClass();

            int[] array = new int[] { 1, 2, 3, 4, 5 };

            Console.Write(x.Arr(array));
        }
    }
}
