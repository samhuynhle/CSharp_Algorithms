/*

We need to establish a dummy node so we can keep track of the start of our returning list.
We need to traverse through both the lists.
This is the two pointers method on different lists, can be applied to array's as well.
Use of while loops and keep track of the inputted lists and our return list

*/

public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2){
        ListNode dummy = new ListNode(-1);

        // We formulate the new linked list with current
        // current1 and current2 are used to traverse through l1 and l2
        ListNode ret = dummy;
        ListNode current1 = l1;
        ListNode current2 = l2;

        // We traverse all the way through one of the lists, l1 or l2
        while(current1 != null & current2 != null){

            // We add either l1 or l2 to our linked list, depending on their value, then move forward
            if(current1.val <= current2.val){
                ret.next = current1;
                current1 = current1.next;
            } else {
                ret.next = current2;
                current2 = current2.next;
            }

            // Move forward in our own list
            ret = ret.next;
        }

        // If there's remaining values of either l1 or l2, we loop through it and add to our linked list
        // Use of ternary operator
        ListNode remaining = current1 != null ? current1 : current2;
        while(remaining != null){
            ret.next = remaining;
            ret = current.next;
            remaining = remaining.next;
        }

        ListNode newHead = dummy.next;
        dummy.next = null;

        return newHead;
    }
}