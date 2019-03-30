using System;

/**
 * 
 * @jingjiejiang Mar 30, 2019
 */
namespace Leetcode.Array
{
    public class MajorityElement
    {
        public int MajorityElement1(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;

            int major = nums[0];
            int count = 1;

            for (int idx = 1; idx < nums.Length; idx ++)
            {
                if (nums[idx] == major)
                {
                    count++;
                }
                else
                {
                    count--;
                    if (count < 0)
                    {
                        major = nums[idx];
                        count = 1;
                    }
                }
            }

            return major;
        }
    }
}
