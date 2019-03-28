using System;
using System.Collections.Generic;

/**
 * 
 * @jingjiejiang Mar 28, 2019
 */
namespace Leetcode.Hash
{
    public class Solution
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            HashSet<int> hashSet = new HashSet<int>(nums1);
            HashSet<int> resSet = new HashSet<int>();
            foreach (int num in nums2)
            {
                if (hashSet.Contains(num))
                {
                    resSet.Add(num);
                }
            }

            int[] resArr = new int[resSet.Count];
            resSet.CopyTo(resArr);

            return resArr;
        }
    }
}
