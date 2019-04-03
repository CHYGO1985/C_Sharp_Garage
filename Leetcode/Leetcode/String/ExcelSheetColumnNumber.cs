using System;

/**
 * 
 * @jingjiejiang April 3, 2019
 */
namespace Leetcode.String
{
    public class ExcelSheetColumnNumber
    {
        public int TitleToNumber(string s)
        {
            int sum = 0;

            for (int offset = 0; offset < s.Length; offset ++)
            {
                int factor = Convert.ToInt32(Math.Pow(26, offset));
                sum += (s[s.Length - 1 - offset] - 'A' + 1) * factor;
            }

            return sum;
        }
    }
}
