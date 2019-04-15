using System;

/*
 * 
 * @jingjiejiang Apr 15, 2019
 */
public class Class1
{
    public int MaxSubArray(int[] nums)
    {
        int curSum = nums[0], sum = nums[0];

        for (int idx = 1; idx < nums.Length; idx ++)
        {
            if (nums[idx] < 0)
            {
                if (curSum >= 0)
                {
                    sum = Math.Max(sum, curSum);
                    curSum += nums[idx];
                }
                else // curSum < 0;
                {
                    sum = Math.Max(sum, Math.Max(curSum, nums[idx]));
                    curSum = nums[idx];
                }
            }
            else // num >= 0
            {
                if (curSum < 0)
                {
                    sum = Math.Max(sum, nums[idx]);
                    curSum = nums[idx];
                }
                else // curSum >= 0 
                {
                    curSum += nums[idx];
                    // do not update here to aovid multi update
                }
            }
        }

        return Math.Max(curSum, sum);
    }
}
