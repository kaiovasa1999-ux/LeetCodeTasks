using System.Linq;

namespace LeetCode.ArrayConcatenation
{

   public class ArrayConcatenationClass
    {
        public int[] Arr(int[] nums)
        {
            int[] array2 = new int[nums.Length * 2];

            for (int i = 0; i < nums.Length; i++)
            {
                array2[i] = nums[i];
            }
            var index = nums.Length;
            for (int i = 0; i < nums.Length; i++)
            {
                array2[index] = nums[i];
                index++;
            }
            return array2;
        }
    }
}
