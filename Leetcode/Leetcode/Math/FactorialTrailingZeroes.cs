using System;

/*
 * 
 * @jingjiejiang Apr 26, 2019
 * ref: https://leetcode.com/problems/factorial-trailing-zeroes/discuss/52371/My-one-line-solutions-in-3-languages
 */
public class Class1
{
    public int TrailingZeroes(int n)
    {
        return n == 0 ? 0 : n / 5 + TrailingZeroes(n / 5);
    }
}
