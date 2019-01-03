using System;

/**
 * @jingjiejiang Jan 03, 2018
 */
namespace Leetcode
{
    public class CreateMaxNum
    {
        public int[] maxNumber(int[] nums1, int[] nums2, int k)
        {
            int limit = Math.Min(nums1.Length, k);
            int[] max = new int[k];

            for (int len = Math.Max(0, k - nums2.Length); len <= limit; len ++)
            {
                int[] part1 = getMaxNum(nums1, len);
                int[] part2 = getMaxNum(nums2, k - len);

                int[] temp = merge(part1, part2);
                max = compare(max, temp, 0, 0) == true ? max : temp;
            }

            return max;
        }

        public int[] merge(int[] nums1, int[] nums2){

            int[] res = new int[nums1.Length + nums2.Length];
            int idx1 = 0, idx2 = 0;

            for (int idx = 0; idx < res.Length; idx ++)
            {
                res[idx] = compare(nums1, nums2, idx1, idx2) == true ?
                    nums1[idx1++] : nums2[idx2++];
            }

            return res;
        }

        // true: nums1, false: nums2
        public Boolean compare (int[] nums1, int[] nums2, int start1, int start2)
        {
            while (start1 < nums1.Length && start2 < nums2.Length && nums1[start1] == nums2[start2])
            {
                start1 ++;
                start2 ++;
            }

            return start2 >= nums2.Length || (start1 < nums1.Length && nums1[start1] > nums2[start2]);
        }

        public int[] getMaxNum(int[] nums, int target)
        {
            int[] res = new int[target];
            int top = 0;

            for (int idx = 0; idx < nums.Length; idx ++)
            {
                while (top > 0 && res[top - 1] < nums[idx] && top + nums.Length - idx > target)
                {
                    top --;
                }

                if (top < res.Length) res[top++] = nums[idx];
            }

            return res;
        }
    }
}
