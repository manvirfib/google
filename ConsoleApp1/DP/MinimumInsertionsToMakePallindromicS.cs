public class MinInsertionsSolution {
    public int MinInsertions(string s) {
        int n = s.Length;
        int[] prev = new int[n + 1];
        int[] cur = new int[n + 1];
        char[] s1 = s.ToCharArray();
        char[] s2 = s1.Reverse().ToArray();

        for(int i = 1; i <= n; i++){
            cur = new int[n + 1];
            for(int j = 1; j <= n; j++){
                if(s1[i - 1] == s2[j - 1]) cur[j] = 1 + prev[j - 1];
                else cur[j] = Math.Max(prev[j], cur[j - 1]);
            }
            prev = cur;
        } 

        return n - prev[n];
    }
    string Reverse(string s){
        char[] ch = s.ToCharArray();
        Array.Reverse(ch);
        return new string(ch);
    }
}