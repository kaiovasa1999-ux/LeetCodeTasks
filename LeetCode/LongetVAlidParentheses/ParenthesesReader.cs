namespace LeetCode.LongetVAlidParentheses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ParenthesesReader
    {
        public int findMaxLen(string str)
        {
            int n = str.Length;

            // Create a stack and push -1 as
            // initial index to it.
            Stack<int> stk = new Stack<int>();
            stk.Push(-1);
            // Initialize result
            int result = 0;

            // Traverse all characters of
            // given string
            for (int i = 0; i < n; i++)
            {
                // If opening bracket, push
                // index of it
                if (str[i] == '(')
                {
                    stk.Push(i);
                }

                else // If closing bracket,
                     // i.e.,str[i] = ')'
                {
                    // Pop the previous opening
                    // bracket's index
                    if (stk.Count > 0)
                        stk.Pop();

                    // Check if this length formed
                    // with base of current valid
                    // substring is more than max
                    // so far
                    if (stk.Count > 0)
                    {
                        result
                            = Math.Max(result,
                                       i - stk.Peek());
                    }

                    // If stack is empty. push current
                    // index as base for next valid
                    // substring (if any)
                    else
                    {
                        stk.Push(i);
                    }
                }
            }

            return result;
        }

        //// Driver Code
        //public static void Main(string[] args)
        //{
        //    string str = "((()()";

        //    // Function call
        //    Console.WriteLine(findMaxLen(str));

        //    str = "()(()))))";

        //    // Function call
        //    Console.WriteLine(findMaxLen(str));
        //}
    }
}
