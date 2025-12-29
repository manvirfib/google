public class MergeTripletsSolution {
    public bool MergeTriplets(int[][] tri, int[] target) {
        bool flag1 = false, flag2 = false, flag3 = false;
        int n = tri.Length;
        for(int i = n - 1; i >= 0; i--){
            if(tri[i][0] > target[0] || tri[i][1] > target[1] || tri[i][2] > target[2]) continue;
            if(tri[i][0] == target[0]) flag1 = true;
            if(tri[i][1] == target[1]) flag2 = true;
            if(tri[i][2] == target[2]) flag3 = true;
            if(flag1 && flag2 && flag3)
                return true;
        }
        return false;
    }
}