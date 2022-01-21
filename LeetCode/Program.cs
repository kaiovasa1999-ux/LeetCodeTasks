namespace LeetCode
{
    using System;
    using LeetCode.ArrayConcatenation;
    using LeetCode.WordPattern;
    using LeetCode.Password;

    using LeetCode.TargetNumInArr;
    using LeetCode.ContainerWithMostWater;
    class Program
    {
        static void Main(string[] args)
        {
            var x = new VolumeMeter();

            int[] array2 = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };

            Console.WriteLine(x.MaxVolumeArea(array2));
        }
    }
}
