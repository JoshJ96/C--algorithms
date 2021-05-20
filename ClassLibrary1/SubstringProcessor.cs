using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class SubstringProcessor
    {
        public static bool RepeatedSubstringPattern(string s)
        {
            List<string> combinations = new List<string>();

            for (int i = 1; i < s.Length; i++)
            {
                combinations.Add(s.Substring(0, i));
            }

            foreach (string combo in combinations)
            {
                string temp = s;

                temp = temp.Replace(combo, "");

                if (temp == "")
                {
                    return true;
                }
            }

            return false;
        }
    }
}
