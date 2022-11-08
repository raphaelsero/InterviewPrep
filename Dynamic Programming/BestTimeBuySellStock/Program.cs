/*
 
You are given an array prices where prices[i] is the price of a given stock on the ith day.
You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.

Input: prices = [7,1,5,3,6,4]
Output: 5
Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
Example 2:

Input: prices = [7,6,4,3,1]
Output: 0
Explanation: In this case, no transactions are done and the max profit = 0.

Constraints:
1 <= prices.length <= 105
0 <= prices[i] <= 104
 
 */

namespace BestTimeBuySellStock
{
    class Program
    {
        public static void Main(string[] args)
        { 
            //TODO: implement test cases
        }

        //We need to find out the maximum difference (which will be the maximum profit) between two numbers in the given array.
        ///Also, the second number (selling price) must be larger than the first one (buying price).

        //In formal terms, we need to find \max(\text{prices[j]} - \text{prices[i]})max(prices[j]−prices[i]), for every ii and jj such that j > ij>i.


        public int BruteForceMaxProfit(int[] prices) //Time: O(N^2), Space: O(1)
        {
            int maxProfit = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    int profit = prices[j] - prices[i];
                    if (profit > maxProfit)
                        maxProfit = profit;
                }
            }
            return maxProfit;

        }

        public int OnePassMaxProfit(int[] prices) //Time: O(N), Space: O(1)
        {
            int minPrice = int.MaxValue;
            int maxProfit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minPrice)
                    minPrice = prices[i];
                else if (prices[i] - minPrice > maxProfit)
                    maxProfit = prices[i] - minPrice;
            }
            return maxProfit;
        }
    }
}