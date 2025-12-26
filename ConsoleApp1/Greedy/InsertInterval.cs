public class InsertIntervalSolution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        List<int[]> list = new();
        int n = intervals.Length;
        int i = 0;

        for(i = 0; i < n; i++){
            if(newInterval[0] > intervals[i][1]){
                list.Add(new int[]{ intervals[i][0], intervals[i][1] });
            }
            else{
                break;
            }
        }
        int min = newInterval[0], max = newInterval[1];
        while(i < n && newInterval[1] >= intervals[i][0]){
            min = Math.Min(min, intervals[i][0]);
            max = Math.Max(max, intervals[i][1]);
            i++;
        }
        list.Add(new int[] { min, max });
        while(i < n){
            list.Add(new int[]{ intervals[i][0], intervals[i][1] });
            i++;
        }
        return list.ToArray();
    }
}