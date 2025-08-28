public class BestTimeToBuyAndSellStock {
    public int MaxProfit(int[] prices) {
        int l = 0, r = 0;
        int result = 0;
        while(r < prices.Length){
            if(prices[l] < prices[r]){
                result = Math.Max(result, prices[r] - prices[l]);
            }
            else{
                l = r;
            }
            r++;
        }

        return result;
    }
}
