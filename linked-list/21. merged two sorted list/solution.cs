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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        // dummy node to simplify edge cases
        ListNode dummy = new ListNode(0);
        ListNode tail = dummy;

        // merge nodes in sorted order
        while (list1 != null && list2 != null) {
            if (list1.val <= list2.val) {
                tail.next = list1;
                list1 = list1.next;
            } else {
                tail.next = list2;
                list2 = list2.next;
            }
            tail = tail.next; // move tail
        }

        // attach remaining nodes from list1 or list2
        if (list1 != null) tail.next = list1;
        if (list2 != null) tail.next = list2;

        // return the merged list (excluding dummy)
        return dummy.next;
    }
}
