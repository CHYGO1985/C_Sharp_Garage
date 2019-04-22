using System;

/*
 * 
 * @jingjiejiang Apr 22, 2019
 */ 
public class Class1
{
    public int PivotIndex(int[] nums)
    {
        if (nums.Length == 0) return -1;

        int[] sums = new int[nums.Length];
        sums[0] = nums[0];

        for (int idx = 1; idx < sums.Length; idx++)
        {
            sums[idx] = sums[idx - 1] + nums[idx];
        }

        int rightSum = 0, leftSum = 0, sum = sums[sums.Length - 1];

        for (int idx = 0; idx < sums.Length; idx++)
        {
            leftSum = (idx > 0) ? sums[idx - 1] : 0;
            rightSum = sum - nums[idx] - leftSum;
            if (leftSum == rightSum) return idx;
        }

        return -1;
    }

    // O(1) space
    public int PivotIndex1(int[] nums)
    {
        if (nums.Length == 0) return -1;

        sums[0] = nums[0];
        int sum = nums.Sum();

        int rightSum = 0, leftSum = 0;

        for (int idx = 0; idx < nums.Length; idx++)
        {
            leftSum = (idx > 0) ? leftSum + nums[idx - 1] : 0;
            rightSum = sum - nums[idx] - leftSum;
            if (leftSum == rightSum) return idx;
        }

        return -1;
    }
}
