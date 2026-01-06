public class ReverseBitsSolution {
    public int ReverseBits(int n) {
        int res = 0;
        for(int i = 0; i < 32; i++){
            if((n & (1 << i)) != 0)
            {
                res = res | (1 << (31 - i)); 
            }
        }
        return res;
    }
}
