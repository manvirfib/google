public class MyPowSolution {
    public double MyPow(double x, int n) {
        double res = 1;
        if(x == 0) return 0;
        if(n == 0) return 1;
        long count = Math.Abs((long)n);
        while(count != 1){
            if(count % 2 != 0){
                res = res * x;
            }
            x = x * x;
            count = count/2;
        }
        res = res * x;
        return n >= 0 ? res : 1/res;
    }
}
