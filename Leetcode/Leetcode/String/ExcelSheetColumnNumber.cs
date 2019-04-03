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
            int factor = 1;

            for (int offset = 0; offset < s.Length; offset ++)
            {
                sum += (s[s.Length - 1 - offset] - 'A' + 1) * factor;
                factor *= 26;
            }

            return sum;
        }
    }
}
