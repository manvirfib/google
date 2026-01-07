public class ReverseSolution {
    public int Reverse(int x) {
        int res = 0;
        int max = int.MaxValue;
        int min = int.MinValue;
        while(x != 0){
            int last = x % 10;
            x = x/10;
            if((res > (max / 10)) || res == (max / 10) && last > max % 10) return 0;
            if(res < (min / 10) || res == (min / 10) && last < max % 10) return 0;
            res = res * 10 + last;
        }
        return res;
    }
}
