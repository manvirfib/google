public class CandySolution {
    public int Candy(int[] ratings) {
        int n = ratings.Length;
        int[] left = new int[n];
        int[] right = new int[n];
        left[0] = 1;

        for(int i = 1; i < n; i++){
            if(ratings[i - 1] < ratings[i]){
                left[i] = left[i - 1] + 1;
            }
            else{
                left[i] = 1;
            }
        }
        right[n - 1] = 1;
        for(int i = n - 2; i >= 0; i--){
            if(ratings[i] > ratings[i + 1]){
                right[i] = right[i + 1] + 1;
            }
            else{
                right[i] = 1;
            }
        }
        int total = 0;
        for(int i = 0; i < n; i++){
            total += Math.Max(left[i], right[i]);
        }
        return total;
    }
}