public class MergeKList {    
    public ListNode MergeKLists(ListNode[] lists) {
        if(lists == null){
            return null;
        }
        return Divide(lists, 0, lists.Length - 1);
    }
    ListNode Divide(ListNode[] lists, int l, int r){
        if(l > r)
        return null;
        if(l == r){
            return lists[l];
        }

        int mid = l + (r - l)/2;

        var left = Divide(lists, l, mid);
        var right = Divide(lists, mid + 1, r);

        return Conquer(left, right);
    }
    ListNode Conquer(ListNode l, ListNode r){
        ListNode result = new ListNode(0);
        var cur = result;

        while(l != null && r != null){
            if(l.val < r.val){
                cur.next = l;
                l = l.next;
            }
            else{
                cur.next = r;
                r = r.next;
            }
            cur = cur.next;
        }
        if(l != null){
            cur.next = l;
            cur = cur.next;
        }
        if(r != null){
            cur.next = r;
            cur = cur.next;
        }

        return result.next;
    }
}