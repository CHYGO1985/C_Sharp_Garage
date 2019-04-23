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

        int head = 1, rear = nums.Length - 2;
        int headNum = nums[head - 1], rearNum = nums[rear + 1];

        while (headNum < rearNum && headNum != rearNum)
        {
            while (headNum < rearNum && nums[head] != headNum)
            {
                headNum = nums[head];
                head ++;
            }

            while (headNum < rearNum && nums[rear] != rearNum)
            {
                rearNum = nums[rear];
                rear --;
            } 

            if (nums[head] != nums[rear])

        }

        return 
    }

    private void swap(int[] nums, int head, int rear)
    {
        int tmp = nums[head];
        nums[head] = nums[rear];
        nums[rear] = tmp;
    }
}
