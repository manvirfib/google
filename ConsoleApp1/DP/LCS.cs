namespace HelloWorld
{
    class LCS
    {
        string s1, s2;
        int[,] dp;
        public LCS(string s1, string s2)
        {
            this.s1 = s1;
            this.s2 = s2;
            dp = new int[s1.Length + 1, s2.Length + 1];
        }
        public int FindLongestSubseq()
        {
            for (int i = 1; i <= s1.Length; i++)
            {
                for (int j = 1; j <= s2.Length; j++)
                {
                    if (s1[i - 1] == s2[j - 1])
                    {
                        dp[i, j] = 1 + dp[i - 1, j - 1];
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                }
            }

            return dp[s1.Length, s2.Length];
            
        }
    }
}