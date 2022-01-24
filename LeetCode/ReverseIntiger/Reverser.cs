namespace LeetCode.ReverseIntiger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Reverser
    {
        public int Reverse(int num)
        {
            //var NumX = num.ToString();

            //var number = "";
            //for (int i = NumX.Length - 1; i >= 0; i--)
            //{
            //    number += NumX[i];
            //}
            //var x = num.ToString().Reverse().Aggregate(0, (b, x) => 10 * b + x - '0');
            //if (num < 0)
            //{
            //    x = x * -1;
            //}
            //return x;
            int left = num;
            int rev = 0;
            while (Convert.ToBoolean(left)) // instead of left>0 , to reverse signed numbers as well
            {
                int r = left % 10;
                rev = rev * 10 + r;
                left = left / 10;  //left = Math.floor(left / 10); 
            }
            return rev;

        }
    }
}
