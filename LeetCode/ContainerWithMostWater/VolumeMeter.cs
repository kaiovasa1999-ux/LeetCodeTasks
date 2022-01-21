namespace LeetCode.ContainerWithMostWater
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class VolumeMeter
    {
        public int MaxVolumeArea(int[] heights)
        {

            var maxArea = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                for (int j = 0; j < heights.Length; j++)
                {
                    var w = j - i;
                    int h = Math.Min(heights[i], heights[j]);
                    maxArea = Math.Max(maxArea, h * w);
                }
            }
            return maxArea;
        }
    }
}
