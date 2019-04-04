using System;

/**
 * 
 * @jingjiejiang April 4, 2019
 */
namespace Leetcode.Array
{
    public class TwoSumII
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            // assume the max sum of two nums in numbers won't > Int.Max
            int head = 0;
            int rear = numbers.Length - 1;
            int[] res = new int[2];

            while (head < rear)
            {
                int sum = numbers[head] + numbers[rear];
                if (sum == target)
                {
                    res[0] = head + 1;
                    res[1] = rear + 1;
                    break;
                }
                else if (sum < target)
                {
                    head++;
                }
                else
                {
                    rear--;
                }
            }

            return res;
        }
    }
}
