using System.Linq;



namespace LeetCode
{
    public class PalindromeClass
    {
        public string IsPalindrome(int x)
        {
            var num = x.ToString();
            var x1 = "";
            foreach (var item in num)
            {
                x1 += item;
            }

            var x1List = x1.ToList();
            var x2 = "";

            for (int i = num.Length - 1; i >= 0; i--)
            {
                x2 += x1[i];
            }
            if (x2 != num)
            {
                return "False";
            }
            return "Palindromes";
        }
    }
}