using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestTimeToBuyAndSellStock
{

    public class Solution
    {
        public int MaxProfit(int[] prices)
        {

            // Declare the variables used in the exercise.
            int minPrice = prices[0];
            int maxProfit = 0;

            // Loop through each day, starting from the second price in the array.
            for (int i = 1; i < prices.Length; i++)
            {
                // Check if the current price is lower than the minimum price found so far.
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                }
                // Otherwise, calculate the current profit and check if it is the highest profit.
                else
                {
                    int currentProfit = prices[i] - minPrice;

                    if (currentProfit > maxProfit)
                    {
                        maxProfit = currentProfit;
                    }
                }
            }
            // Return the maximum profit found.
            return maxProfit;
        }
    }
}
