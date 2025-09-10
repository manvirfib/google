public class RemoveNthNodeFromEnd {
    int num = 0;
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        if(head == null || head.next == null){
            num++;
            if(num == n)
            return head.next;
            return head;
        }
        head.next = RemoveNthFromEnd(head.next, n);
        num++;
        if(num == n)
            return head.next;
        return head;
    }
}