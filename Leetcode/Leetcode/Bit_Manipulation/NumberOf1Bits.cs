using System;

/*
 * 
 * @jingjiejiang Apr 19, 2019
 */
public class Class1
{
    public int HammingWeight(uint n)
    {
        int ans = 0;
        while (n != 0)
        {
            ans += (int)n & 1;
            n >>= 1;
        }
        return ans;
    }
}
