public class TrappingRainWater {
    public int Trap(int[] height) {
        int lmax = 0;
        int rmax = height.Length - 1;
        int area = 0;
        while(lmax < rmax){
            int i = 0;
            if(height[lmax] < height[rmax]){
                i = lmax + 1;
                while(height[lmax] > height[i]){
                    area += Math.Min(height[lmax], height[rmax]) - height[i];
                    i++;
                }
                lmax = i;
                i++;
            }
            else{
                i = rmax - 1;
                while(height[rmax] > height[i]){
                    area += Math.Min(height[lmax], height[rmax]) - height[i];
                    i--;
                }
                rmax = i;
                i--;
            }
        }

        return area;
    }
}