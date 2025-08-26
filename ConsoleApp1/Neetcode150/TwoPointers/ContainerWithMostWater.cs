public class ContainerWithMostWater {
    public int MaxArea(int[] heights) {
        int i = 0, j = heights.Length - 1, result = 0, temp = 0;
        while(i < j){
            temp = Math.Min(heights[i], heights[j]) * (j-i);
            result = Math.Max(temp, result);
            if(heights[i] <= heights[j]){
                i++;
            }
            else{
                j--;
            }
        }

        return result;
    }
}
