using System;

/*
 * 
 * @jingjiejiang Apr 12, 2019
 */
public class Class1
{
    public int ClimbStairs(int n)
    {
        int[] steps = new int[n + 2];
        steps[0] = 0;
        steps[1] = 1;

        for (int idx = 1; idx <= n; idx++)
        {
            steps[idx + 1] = steps[idx] + steps[idx - 1];
        }

        return steps[n + 1];
    }
}
