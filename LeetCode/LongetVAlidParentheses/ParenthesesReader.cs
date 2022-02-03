namespace LeetCode.LongetVAlidParentheses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ParenthesesReader
    {
        public  int findMaxLen(string str)
        {
            int n = str.Length;

            Stack<int> stk = new Stack<int>();
            stk.Push(-1);
            int result = 0;

            for (int i = 0; i < n; i++)
            {
                if (str[i] == '(')
                {
                    stk.Push(i);
                }

                else 
                {
                    if (stk.Count > 0)
                        stk.Pop();

                    if (stk.Count > 0)
                    {
                        result = Math.Max(result, i - stk.Peek());
                    }

                    else
                    {
                        stk.Push(i);
                    }
                }
            }

            return result;
        }

      
    }
}
