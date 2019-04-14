using System;
using System.Text;

/*
 * @jingjiejiang Apr 14, 2019 
 */
namespace Leetcode.String
{
    public class AddStrings
    {
        public string AddStrings1(string num1, string num2)
        {
            if (num1 == null || num2 == null)
            {
                return num2 == null ? num1 : num2;
            }
                 
            int carrier = 0, len = Math.Max(num1.Length, num2.Length);
            StringBuilder res = new StringBuilder();

            for (int idx = 0; idx < len; idx++)
            {
                int num1Idx = num1.Length - idx - 1;
                int num2Idx = num2.Length - idx - 1;
                int tmp1 = num1Idx >= 0 ? num1[num1Idx] - '0' : 0;
                int tmp2 = num2Idx >= 0 ? num2[num2Idx] - '0' : 0;
                int tmpSum = tmp1 + tmp2 + carrier;

                // reset carrier
                carrier = tmpSum >= 10 ? 1 : 0;
                res.Insert(0, tmpSum % 10);
            }

            if (carrier > 0)
            {
                res.Insert(0, carrier);
            }

            return res.ToString();
        }
    }
}
