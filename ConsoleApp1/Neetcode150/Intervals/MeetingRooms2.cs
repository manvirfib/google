/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class MinMeetingRooms2Solution {
    public int MinMeetingRooms(List<Interval> inv) {
        int n = inv.Count;
        int[] timer = new int[n + 1];
        inv.Sort((a, b) => a.start.CompareTo(b.start));
        int max = -1;

        for(int i = 0; i < n; i++){
            int start = inv[i].start;
            int end = inv[i].end;
            int duration = end - start;
            for(int j = 0; j <= n; j++){
                if(timer[j] <= start){
                    timer[j] = end;
                    max = Math.Max(j, max);
                    break;
                }
            }
        }

        return max != -1 ? max + 1 : 0;
    }
}
