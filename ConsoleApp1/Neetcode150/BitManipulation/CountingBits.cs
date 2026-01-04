public class CountBitsSolution {
    public int[] CountBits(int n) {
        int[] res = new int[n + 1];
        int power2 = 1;
        res[0] = 0;
        int offset = 1;
        for(int i = 1; i <= n; i++){
            if(i == power2){
                offset = power2;
                power2 *= 2;
            }
            res[i] = 1 + res[i - offset];
        }
        return res;
    }
}
// In order to complete this, we have to find the pattern, so dry run