namespace HelloWorld
{
    class MaximumSubSum
    {
        int[] dp;
        int[] arr;

        public MaximumSubSum(int[] arr)
        {
            this.arr = arr;
            dp = new int[arr.Length]; // no need for +1
        }

        public int FindSubSum()
        {
            dp[0] = arr[0];
            int result = arr[0]; // start with first element

            for (int i = 1; i < arr.Length; i++)
            {
                dp[i] = Math.Max(arr[i], dp[i - 1] + arr[i]);
                result = Math.Max(result, dp[i]);
            }

            return result;
        }
    }
}
