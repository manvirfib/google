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

public class MinMeetingRoomsSolution {
    public int MinMeetingRooms(List<Interval> inv) {
        int n = inv.Count;
        if(n == 0) return 0;
        inv.Sort((a, b) => a.start.CompareTo(b.start));
        PriorityQueue<int, int> pq = new();
        int i = 1;
        pq.Enqueue(inv[0].end, inv[0].end);

        while(i < n){
            if(pq.Peek() <= inv[i].start){
                pq.Dequeue();
            }
            pq.Enqueue(inv[i].end, inv[i].end);
            i++;
        }

        return pq.Count;
    }
}
