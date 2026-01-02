public class PlusOneSolution {
    public int[] PlusOne(int[] digits) {
        List<int> res = new();
        int rem = 1;
        int n = digits.Length;
        for(int i = n - 1; i >= 0; i--){
            if(rem == 1){
                if(digits[i] == 9){
                    res.Add(0);
                    rem = 1;
                }
                else{
                    res.Add(digits[i] + 1);
                    rem = 0;
                }
            }
            else{
                res.Add(digits[i]);
            }
        }
        if(rem == 1) res.Add(rem);
        res.Reverse();

        return res.ToArray();
    }
}