public class AddTwoNumbersLL {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode first = null, cur = null;
        int carry = 0;

        while(l1 != null || l2 != null){
            ListNode temp = new ListNode();
            int tot = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + carry;
            temp.val = (tot) % 10;
            carry = tot / 10;
            if(first == null){
                first = temp;
                cur = first;
            }
            else{
                cur.next = temp;
                cur = cur.next;
            }
            if(l1 != null)
            l1 = l1.next;
            if(l2 != null)
            l2 = l2.next;
        }

        if(carry != 0){
            cur.next = new ListNode(1);
        }

        return first;
    }
}