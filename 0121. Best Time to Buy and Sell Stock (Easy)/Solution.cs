public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int minValIndex = 0, maxProfit = 0;
        for (int i = 1; i < prices.Length; i++)
            if (prices[i] < prices[i - 1] && prices[i] < prices[minValIndex])
                minValIndex = i;
            else if (prices[i] - prices[minValIndex] > maxProfit)
                maxProfit = prices[i] - prices[minValIndex];
        return maxProfit;
    }
}