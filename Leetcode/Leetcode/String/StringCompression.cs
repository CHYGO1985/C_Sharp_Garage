using System;

/*
 * 
 * @jingjiejiang Apr 25, 2017
 */ 
public class Class1
{
    // method 1: use an array as a hash to store the letters count, then cound the len O(n) space complexity
    // method 2: 
    public int Compress(char[] chars)
    {

        if (chars.Length == 1) return 1;

        int head = 1, shift = 1;
        char standChar = chars[0];

        while (shift < chars.Length)
        {
            int repCount = 1;
            while (shift < chars.Length && standChar == chars[shift])
            {
                repCount++;
                shift++;
            }

            if (repCount > 1)
            {
                string num = repCount.ToString();
                for (int idx = 0; idx < num.Length; idx++)
                {
                    chars[head++] = num[idx];
                }
            }

            if (shift < chars.Length)
            {
                standChar = chars[shift];
                chars[head++] = standChar;
            }
            shift++;
        }

        return head;
    }
}
