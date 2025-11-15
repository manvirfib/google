class Froggy {
    public int minCost(int[] ht) {
        // code here
        int n = ht.Length; // 4
        
        if(n == 1) return 0;
        
        int a = 0;
        int b = Math.Abs(ht[1] - ht[0]);
        
        if(n == 2) return b;
        
        for(int i = 2; i < n; i++){
            int h1 = b + Math.Abs(ht[i] - ht[i - 1]);
            int h2 = a + Math.Abs(ht[i] - ht[i - 2]);
            int temp = Math.Min(h1, h2);
            a = b;
            b = temp;
        }
        
        return b;
    }
}