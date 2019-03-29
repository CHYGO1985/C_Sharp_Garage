using System;
using System.Collections.Generic;

/**
 * 
 * @jingjiejiang Mar 29, 2019
 */
namespace Leetcode.Array
{
    public class Solution
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            IList<int> res = new List<int>();

            for (int idx = 0; idx < nums.Length; idx++)
            {
                if (nums[idx] != idx + 1)
                {
                    int tmp = nums[nums[idx] - 1];
                    nums[nums[idx] - 1] = nums[idx];
                    // keep swapping the nums
                    while (nums[tmp - 1] != tmp)
                    {
                        int newTmp = nums[tmp - 1];
                        nums[tmp - 1] = tmp;
                        tmp = newTmp;
                    }
                }
                // else continue
            }

            for (int idx = 0; idx < nums.Length; idx++)
            {
                if (nums[idx] != idx + 1)
                {
                    res.Add(idx + 1);
                }
            }

            return res;
        }
    }
}
