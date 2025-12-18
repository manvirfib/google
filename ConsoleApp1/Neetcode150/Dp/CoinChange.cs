public class CoinChangeSolution {
    int Rec(int idx, int[] coins, int am, int[] dp){
        if(am == 0) return 0;
        if(idx == 0){
            if(am % coins[idx] == 0) return am / coins[idx];
            return (int)1e9;
        }

        int notTake = Rec(idx - 1, coins, am, dp);
        int take = (int)1e9;

        if(am >= coins[idx]){
            take = 1 + Rec(idx, coins, am - coins[idx], dp);
        }

        return Math.Min(take, notTake);
    }
    public int CoinChange(int[] coins, int amount) {
        int n = coins.Length;
        int[] dp = new int[n];

        Array.Fill(dp, -1);

        int temp = Rec(n - 1, coins, amount, dp);

        return temp == (int)1e9 ? -1 : temp;
    }
}
