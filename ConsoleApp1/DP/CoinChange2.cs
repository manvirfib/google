public class CoinChange2 {
    public int Change(int amount, int[] arr) {
        int n = arr.Length;
        int[,] dp = new int[n, amount + 1];

        for(int i = 0; i <= amount; i++){
            if(i % arr[0] == 0)
                dp[0, i] = 1;
        }

        for(int i = 1; i < n; i++){
            for(int j = 0; j <= amount; j++){
                int notPick = dp[i - 1, j];
                int pick = 0;

                if(arr[i] <= j){
                    pick = dp[i, j - arr[i]];
                }

                dp[i, j] = pick + notPick;
            }
        }

        return dp[n - 1, amount];
    }
}