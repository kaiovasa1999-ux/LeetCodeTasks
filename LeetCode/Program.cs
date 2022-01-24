namespace LeetCode
{
    using System;
    using LeetCode.ArrayConcatenation;
    using LeetCode.WordPattern;
    using LeetCode.Password;
    using LeetCode.LongestPalindrome;
    using LeetCode.TargetNumInArr;
    using LeetCode.ContainerWithMostWater;
    using LeetCode.ReverseIntiger;
    class Program
    {
        static void Main(string[] args)
        {
            var x = new Reverser();

            var text = 0123;

            Console.WriteLine(x.Reverse(text));
        }
    }
}
