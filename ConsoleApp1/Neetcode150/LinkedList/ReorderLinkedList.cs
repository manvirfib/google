public class ReorderLinkedList {
    public void ReorderList(ListNode head) {
        if(head == null || head.next == null)
        return;

        ListNode slow = head, fast = head.next;

        while(fast != null && fast.next != null){
            slow = slow.next;
            fast = fast.next.next;
        }

        ListNode sec = slow.next;
        slow.next = null;

        //reversing the list
        sec = ReverseList(sec);
        
        ListNode first = head;
        while (sec != null) {
            ListNode tmp1 = first.next;
            ListNode tmp2 = sec.next;
            first.next = sec;
            sec.next = tmp1;
            first = tmp1;
            sec = tmp2;
        }

        return;
    }

    public ListNode ReverseList(ListNode head) {
        ListNode prev = null;
        ListNode curr = head;

        while (curr != null) {
            ListNode temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }
        return prev;
    }
}