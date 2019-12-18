public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2){
        ListNode dummy = new ListNode(-1);

        ListNode current = dummy;
        ListNode current1 = l1;
        ListNode current2 = l2;

        while(current1 != null & current2 != null){
            if(current1.val <= current2.val){
                current.next = current1;
                current1 = current1.next;
            } else {
                current.next = current2;
                current2 = current2.next;
            }

            current = current.next;
        }

        ListNode rest = current1 != null ? current1 : current2;
        while(rest != null){
            current.next = rest;
            current = current.next;
            rest = rest.next;
        }

        ListNode newHead = dummy.next;
        dummy.next = null;

        return newHead;
    }
}