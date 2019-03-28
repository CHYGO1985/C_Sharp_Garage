using System;
namespace Leetcode.Array
{
    public class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            int zeroIdx = 0;
            while (nums[zeroIdx] != 0 && zeroIdx < nums.Length) zeroIdx++;

            int shiftIdx = zeroIdx + 1;
            while (shiftIdx < nums.Length)
            {
                if (nums[shiftIdx] != 0)
                {
                    nums[zeroIdx] = nums[shiftIdx];
                    nums[shiftIdx] = 0;
                    zeroIdx++;
                }
             
                shiftIdx ++;
            }
        }
    }
}
