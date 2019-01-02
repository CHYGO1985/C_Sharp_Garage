using System;

/**
 * @jingjiejiang Jan 02, 2018
 */
namespace Leetcode
{
    public class CreateMaxNum
    {
        public int[] maxNumber(int[] nums1, int[] nums2, int k)
        {

        }

        public int[] merget(int[] nums1, int[] nums2){

            int[] res = new int[nums1.Length + nums2.Length];
            int idx1 = 0, idx2 = 0;

            for (int idx = 0; idx < res.Length; idx ++)
            {
                res[idx] = compare(nums1, nums2, idx1, idx2) == true ?
                    nums1[idx1++] : nums2[idx2++];
            }

            return 
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
