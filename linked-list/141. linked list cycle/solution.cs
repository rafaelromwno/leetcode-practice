/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        
        ListNode slow = head;
        ListNode fast = head;

        while(fast != null && fast.next != null){

            slow = slow.next; // 1 move
            fast = fast.next.next; // 2 moves

            if(fast == slow) // if there are cycles, at some point the pointers will be equal
                return true;
        }

        return false; // end of list => no cycles

    }
}
