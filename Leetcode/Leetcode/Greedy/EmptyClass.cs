using System;
namespace Leetcode.Greedy
{
    public class EmptyClass
    {
        public static int MinPatches(int[] nums, int n)
        {
            int count = 0;
            long sum = 0;

            for (int idx = 0; idx < nums.Length; idx++)
            {
                int limit = Math.Min(nums[idx] - 1, n);
                while (sum < limit)
                {
                    sum += sum + 1;
                    count++;
                }
                sum += nums[idx];
            }

            while (sum < n)
            {
                sum += sum + 1;
                count++;
            }

            return count;
        }

    }
}
