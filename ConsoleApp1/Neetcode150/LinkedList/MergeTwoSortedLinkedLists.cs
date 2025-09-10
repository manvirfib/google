public class MergeTwoSortedLists {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode first = null, p = null;

        if(list1 == null)
        return list2;
        if(list2 == null)
        return list1;
        while(list1 != null && list2 != null){
            var temp = new ListNode();
            
            if(list1.val < list2.val){
                temp.val = list1.val;
                list1 = list1.next;
            }
            else{
                temp.val = list2.val;
                list2 = list2.next;
            }

            if(first == null){
                first = temp;
                p = first;
            }
            else{
                p.next = temp;
                p = p.next;
            }
        }

        p.next = list1 ?? list2;

        return first;
    }
}