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
    class Program
    {
        static void Main(string[] args)
        {
            var x = new PiCalculation();

            var text = 23452522234242;

            Console.WriteLine(x.EstimitePi(text));
        }
    }
}
