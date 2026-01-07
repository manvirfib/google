public class GetSumSolution {
    public int GetSum(int a, int b) {
        int sum = 0;
        do{
            sum = a ^ b;
            b = (a & b) << 1;
            a = sum;
        } while(b != 0);

        return sum;
    }
}