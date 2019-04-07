using System;

/**
 * 
 * @jingjiejiang April 7, 2019
 */
namespace Leetcode.Dynamic_Programming
{
    public class BestTimeToBuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            int[] profits = new int[2];
            profits[0] = 0;
            profits[1] = Int32.MinValue;

            foreach (int price in prices)
            {
                profits[0] = Math.Max(profits[0], profits[1] + price);
                profits[1] = Math.Max(profits[1], -price);
            }

            return profits[0];
        }
    }
}
