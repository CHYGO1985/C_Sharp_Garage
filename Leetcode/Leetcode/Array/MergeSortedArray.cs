using System;

/*
 * 
 * @jingjiejiang Mar 2, 2019
 */ 
public class Class1
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int finalTail = nums1.Length - 1, nums1Tail = m - 1, nums2Tail = n - 1;
        
        while (nums1Tail >= 0 && nums2Tail >= 0)
        {
            nums1[finalTail --] = (nums1[nums1Tail] >= nums2[nums2Tail]) ? nums1[nums1Tail --] : nums2[nums2Tail --];
        }

        while (nums1Tail >= 0)
        {
            nums1[finalTail --] = nums1[nums1Tail--];
        }

        while (nums2Tail >= 0)
        {
            nums1[finalTail--] = nums2[nums2Tail--];
        }
    }
}
