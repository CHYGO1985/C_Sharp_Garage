using System;

/**
 * 
 * @jingjiejiang April 2, 2019
 */
namespace Leetcode.Dynamic_Programming
{
    public class BestTimeBuySellStockII
    {
        public int MaxProfit(int[] prices)
        {
            int[,] profits = new int[2, 2];
            profits[0, 0] = 0;
            profits[0, 1] = int.MinValue;

            for (int idx = 0; idx < prices.Length; idx ++)
            {
                profits[(idx + 1) % 2, 0] = Math.Max(profits[idx % 2, 0], profits[idx % 2, 1] + prices[idx]);
                profits[(idx + 1) % 2, 1] = Math.Max(profits[idx % 2, 1], profits[idx % 2, 0] - prices[idx]);
            }

            return profits[prices.Length % 2, 0];
        }
    }
}
