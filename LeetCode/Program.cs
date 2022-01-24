namespace LeetCode
{
    using System;
    using LeetCode.ArrayConcatenation;
    using LeetCode.WordPattern;
    using LeetCode.Password;
    using LeetCode.LongestPalindrome;
    using LeetCode.TargetNumInArr;
    using LeetCode.ContainerWithMostWater;
    class Program
    {
        static void Main(string[] args)
        {
            var x = new PalindromeTextReader();

            var text = "aaaracecarbbb";

            Console.WriteLine(x.Checker(text));
        }
    }
}
