using System;
using System.Collections.Generic;

namespace Leetcode.Queue
{
    public class MovingAverage
    {
        private Queue<int> queue;
        private int size;
        private int sum;

        /** Initialize your data structure here. */
        public MovingAverage(int size)
        {
            queue = new Queue<int>();
            this.size = size;
            sum = 0;
        }

        public double Next(int val)
        {
            if (queue.Count < size)
            {
                queue.Enqueue(val);
                sum += val;
            }
            else
            {
                int old = queue.Dequeue();
                queue.Enqueue(val);
                sum = sum - old + val;
            }

            return (double)sum / queue.Count;
        }
    }
}
