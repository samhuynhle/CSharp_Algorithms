/*
Definition for singly-linked list.
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}
*/
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) { // takes two linked lists, which store reverse order numbers: 847 is represented as 7 -> 4 -> 8
        ListNode dummy = new ListNode(0); // we need to initialize a dummy node so we know where the start of our list is (will be dummy.next)
        ListNode current = dummy; // get a current runner
        int carry = 0; // this store if there is a carry over at either point of the while loop
        
        while(l1 != null || l2 != null){ // while either of the lists are still valid
            int sum = carry + ((l1 != null) ? l1.val : 0) + ((l2 != null) ? l2.val : 0); // this is where we calculate the sum for each iteration
            carry = sum / 10; // if the sum is > 10 we have a carry, if it's not carry is 0
            current.next = new ListNode(sum % 10); // we save the value into the linked list, we use % 10 just in case the value is > 10
            current = current.next; // move our marker

            // we move within the linked lists if they we valid, if they were null we leave it as null
            // We are using ternary arguement to either assigning to .next or keeping l1/l2 as is
            l1 = ((l1 != null) ? l1.next : l1);
            l2 = ((l2 != null) ? l2.next : l2);
        }
        if(carry > 0){ // if there is a left over carry we add it
            current.next = new ListNode(carry);
        }
        return dummy.next;
    }
}