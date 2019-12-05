/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;
        int carry = 0;
        
        while(l1 != null || l2 != null){
            int sum = carry + ((l1 != null) ? l1.val : 0) + ((l2 != null) ? l2.val : 0);
            carry = sum / 10;
            current.next = new ListNode(sum % 10);
            current = current.next;
            l1 = ((l1 != null) ? l1.next : l1);
            l2 = ((l2 != null) ? l2.next : l2);
        }
        if(carry > 0){
            current.next = new ListNode(carry);
        }
        return dummy.next;
    }
}