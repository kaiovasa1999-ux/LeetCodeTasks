namespace LeetCode
{
    using System;
    using LeetCode.ArrayConcatenation;
    using LeetCode.WordPattern;

    class Program
    {
        static void Main(string[] args)
        {
            var x = new PatternChecker();
            Console.Write(x.Checker("aaa", "aba asba aba"));
        }
    }
}
