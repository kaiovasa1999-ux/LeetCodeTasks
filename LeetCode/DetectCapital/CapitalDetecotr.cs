namespace LeetCode.DetectCapital
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CapitalDetecotr
    {
        public bool DetectCapitalUse(string word)
        {
            var counter = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word.Length == 1)
                {
                    return true;
                }

                if (Char.IsUpper(word[i]) && i == 0 && counter == 1)
                {
                    counter++;
                    return true;
                }
                if (!Char.IsUpper(word[i]))
                {
                    return false;
                }
               
            }
            return true;
        }
    }
}
