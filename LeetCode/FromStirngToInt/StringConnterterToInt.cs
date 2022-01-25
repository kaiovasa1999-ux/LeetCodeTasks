namespace LeetCode.FromStirngToInt
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StringConnterterToInt
    {
        public int TextToNumConvert(string text)
        {
            return text.Aggregate(0, (b, x) => 10 * b + x - '0');
        }
    }
}
