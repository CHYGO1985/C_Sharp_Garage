using System;

/*
 * 
 * @jingjiejiang Apr 23, 2019
 */ 
public class Class1
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums == null || nums.Length == 0) return 0;
        if (nums.Length == 1) return 1;

        int headIdx = 0, shiftIdx = 1;

        while (shiftIdx < nums.Length)
        {
            while (shiftIdx < nums.Length && nums[headIdx] == nums[shiftIdx]) shiftIdx ++;
             
            if (shiftIdx < nums.Length)
            {
                swap(nums, headIdx + 1, shiftIdx);
                headIdx += 1;
                shiftIdx += 1;
            }
        }

        return headIdx + 1;
    }

    private void swap(int[] nums, int head, int rear)
    {
        int tmp = nums[head];
        nums[head] = nums[rear];
        nums[rear] = tmp;
    }
}
