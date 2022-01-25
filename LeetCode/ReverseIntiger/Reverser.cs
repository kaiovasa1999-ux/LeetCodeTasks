namespace LeetCode.ReverseIntiger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Reverser
    {
        public long Reverse(int num)
        {
            int left = num;
            long revL = 0;
            int rev = 0;
            var maxInt = int.MaxValue;

            while (Convert.ToBoolean(left))
            {
                int r = left % 10;
                revL = revL * 10 + r;
                rev = rev * 10 + r;
                left = left / 10;
            }

            // Whit this we make sure the reverset number is not bigger or greather then (int.MaxValue || int.MaxValue * -1)
            // Becouse the function have to return Int value type and couldn't be possible if is not in range of int.
            if (revL > maxInt)
            {
                rev = 0;
     
                return 0;
            }
            if(revL < maxInt * -1)
            {
                return 0;
            }
         
            return rev;

        }
    }
}
