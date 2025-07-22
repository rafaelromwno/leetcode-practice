/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MiddleNode(ListNode head) {
        
        ListNode fast = head;
        ListNode slow = head;

        while(fast != null && fast.next != null){

            slow = slow.next; // move 1 step
            fast = fast.next.next; // move 2 steps

        }

        return slow; // when fast reaches the end, slow is at the middle

    }
}
