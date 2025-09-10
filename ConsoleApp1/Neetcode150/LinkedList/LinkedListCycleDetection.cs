public class CycleDetection {
    public bool HasCycle(ListNode head) {
        ListNode fir = head, sec = head;
        if(head == null || head.next == null)
            return false;

        while(sec != null && sec.next != null){
            fir = fir.next;
            sec = sec.next.next;

            if(fir == sec){
                return true;
            }
        }

        return false;
    }
}