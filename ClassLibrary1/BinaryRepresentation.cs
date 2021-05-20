using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    /*
    https://leetcode.com/problems/number-of-steps-to-reduce-a-number-in-binary-representation-to-one/submissions/ 



     
     */
    public static class BinaryRepresentation
    {
        public static int NumSteps(string s)
        {
            int non_tr_0 = 0;
            int i = s.Length - 1;

            while (i >= 0 && s[i] != '1')
            {
                i--;   // to reach till last '1'
            }

            if (i == 0)  //for special case like '1000'
                return s.Length - 1;

            for (int j = i; j > 0; j--) //starting from index 1 because s[0] is always '1'
            {
                if (s[j] == '0')
                    non_tr_0++;
            }

            return (s.Length + 1 + non_tr_0);
        }
    }
}
