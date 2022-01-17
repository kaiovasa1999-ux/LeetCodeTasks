using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.WordPattern
{
    public class PatternChecker
    {
        public string Checker(string pattern, string words)
        {
            var wordsList = words.Split().ToList();
            var patternList = new List<Char>();
            foreach (var item in pattern)
            {
                patternList.Add(item);
            }

            if(pattern.Length != wordsList.Count())
            {
                return "False";
            }
            var x = 0;
            for (int i = 0; i < patternList.Count(); i++)
            {
                if (i == 0)
                {
                   if(patternList[0] == patternList[1] && wordsList[0] == wordsList[1])
                    {
                        x++;
                    }
                }

                if(i > 0)
                {
                    if (patternList[i] == patternList[i - 1] && wordsList[i] == wordsList[i - 1])
                    {
                        x++;
                    }
                }
           
            }
            if(x < patternList.Count())
            {
                return "False";
            }
            return "Gooood!!!";

        }
    }
}
