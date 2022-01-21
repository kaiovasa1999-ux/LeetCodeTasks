namespace LeetCode.TargetNumInArr
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SumTarget
    {
        public string SumTarge(int[] arr, int target)
        {
            var res = string.Empty;
            var n1 = 0;
            var n2 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                n1 = arr[i];
                for (int  j = 0; j < arr.Length; j++)
                {
                    n2 = arr[j];
                    if (j == i)
                    {
                        
                        continue;
                    }
                    if(n1 + n2  == target)
                    {
                        res += $"[{i}, {j}]";
                        return res;
                    }
                }
            }
            return "Not found";
        }
    }
}
