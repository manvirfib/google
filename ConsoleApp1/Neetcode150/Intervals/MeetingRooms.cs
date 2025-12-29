public class Interval {
    public int start, end;
    public Interval(int start, int end) {
        this.start = start;
        this.end = end;
    }
}

public class CanAttendMeetingsSolution {
    public bool CanAttendMeetings(List<Interval> inv) {
        if(inv.Count == 0) return true;
        inv.Sort((a, b) => a.start.CompareTo(b.start));
        int end = inv[0].end;
        int i = 1;
        while(i < inv.Count){
            if(end > inv[i].start) return false;
            end = inv[i].end;
            i++;
        }
        return true;
    }
}
