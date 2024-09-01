public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int buy = 0;

        for(int sell = 1; sell < prices.Length; ++sell)
        {
            if(prices[sell] > prices[buy])
            {
                int profit = prices[sell] - prices[buy];
                
                if(profit > maxProfit)
                    maxProfit = profit;
            }
            else
                buy = sell;
        }

        return maxProfit;
    }
}