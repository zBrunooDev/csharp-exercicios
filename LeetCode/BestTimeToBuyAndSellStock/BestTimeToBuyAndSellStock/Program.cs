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

            int menorIndice = 0;
            int maiorIndice = 0;

            for (int i = 0; i <= prices.Length; i++)
            {
                if (prices[i] < prices[menorIndice])
                {
                    menorIndice = i;
                }

            }

            int menorValor = prices[menorIndice];

            for (int i = menorIndice; i <= prices.Length; i++)
            {
                if (prices[i] < prices[maiorIndice])
                {
                    maiorIndice = i;
                }
            }
            int maiorValor = prices[maiorIndice];

            int lucro = menorValor - maiorValor;

            if (lucro <= 0)
            {
                return 0;
            }
            else
            {
                return lucro;
            }

            // First attempt completed. The current logic needs improvement to correctly handle the order between buying and selling.

        }
    }
}
