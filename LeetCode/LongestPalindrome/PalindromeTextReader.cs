
namespace LeetCode.LongestPalindrome
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PalindromeTextReader
    {
        int lenth = 0;
        int startIndex = 0;

        public string Checker(string text)
        {

            var word = string.Empty;
            if(text == null || text.Length == 1)
            {
                return text;
            }

            for (int i = startIndex; i < text.Length; i++)
            {
                CheckForLongestPalindrome(text, i, i);
                CheckForLongestPalindrome(text, i, i + 1);
            }

            return text.Substring(startIndex,lenth);
          
        }
        public void CheckForLongestPalindrome(string s, int l, int r)
        {
            while (l >= 0 && r < s.Length && s[l] == s[r])
            {
                l--;
                r++;
            }
            var res = r - l - 1;
            if (res > lenth)
            {
                lenth = res;
                startIndex = l + 1;
            }
            
        }
    }
}
