public class EraseOverlapIntervalsSolution {
    public int EraseOverlapIntervals(int[][] inv) {
        Array.Sort(inv, (a, b) => a[1].CompareTo(b[1]));
        int count = 1;
        int val = inv[0][1];
        for(int i = 1; i < inv.Length; i++){
            if(val <= inv[i][0]){
                val = inv[i][1];
                count++;
            }
        }
        return inv.Length - count;
    }
}
