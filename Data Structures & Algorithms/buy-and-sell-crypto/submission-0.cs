public class Solution {
    public int MaxProfit(int[] prices) {
        int minp = prices[0];
        int maxprofit = 0;


        for(int i = 1; i <prices.Length;i++)
        {
            int profit = prices[i] - minp;
             maxprofit = Math.Max(profit, maxprofit);
            minp = Math.Min(minp, prices[i]); 
        }
        return maxprofit;
    }
}
