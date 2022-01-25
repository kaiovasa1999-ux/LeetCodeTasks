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
    using LeetCode.DetectCapital;
    using LeetCode.FromStirngToInt;
    using LeetCode.PointsInTheArea;
    using LeetCode.LongetVAlidParentheses;
    class Program
    {
        static void Main(string[] args)
        {
            var x = new ParenthesesReader();

            var text = ")()())";

            Console.WriteLine(x.findMaxLen(text));
        }
    }
}
