public class ReverseKGroupList {
    public ListNode ReverseKGroup(ListNode head, int k) {
        int count;
        ListNode right = head, q = null;
        List<ListNode> lists = new List<ListNode>();
        bool flag = false;

        while(head != null){
            count = 0;
            while(count < k && right != null){
                q = right;
                right = right.next;
                count++;
            }
            if(q != null){
                q.next = null;
                if(count == k){
                    lists.Add(head);
                    head = right;
                }
                else{
                    flag = true;
                    break;
                }
            }
        }
        ListNode res = new ListNode(0);
        var cur = res;
        foreach(var list in lists){
            res.next = ReverseList(null, list);
            while(res.next != null){
                res = res.next;
            }
        }

        if(flag == true){
            res.next = head;
        }

        return cur.next;
    }
    ListNode ReverseList(ListNode p, ListNode q){
        if(q == null){
            return p;
        }
        var r = ReverseList(q, q.next);
        q.next = p;

        return r;
    }
}