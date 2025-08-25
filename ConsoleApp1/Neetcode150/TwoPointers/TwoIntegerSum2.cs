public class TwoIntegerSum2 {
    public int[] TwoSum(int[] numbers, int target) {
        int i = 0, j = numbers.Length - 1;
        int[] result = new int[2];

        while(i < j){
            if((numbers[i] + numbers[j]) == target){
                break;
            }
            if((numbers[i] + numbers[j]) > target){
                j--;
            }
            else{
                i++;
            }
        }

        result[0] = i+1; 
        result[1] = j+1;

        return result;
    }
}
