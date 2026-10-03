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
            int minPrice = prices[0];
            int maxProfit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                }
                else
                {
                    int lucroAtual = prices[i] - minPrice;

                    if (lucroAtual > maxProfit)
                    {
                        maxProfit = lucroAtual;
                    }
                }
            }

            return maxProfit;
        }
    }
}
