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

    public ListNode SortList(ListNode head) 
    {
        // caso-base
        if( head == null || head.next == null)
            return head;

        ListNode middle = GetMiddle(head);
        ListNode right = middle.next;
        middle.next = null; // corta a lista

        ListNode leftSorted = SortList(head);
        ListNode rightSorted = SortList(right);

        return Merge(leftSorted, rightSorted);

    }

    private ListNode GetMiddle(ListNode head)
    {
        ListNode slow = head;
        ListNode fast = head.next;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        return slow;
    }

    private ListNode Merge(ListNode l1, ListNode l2)
    {
        ListNode dummy = new ListNode();
        ListNode tail = dummy;

        while (l1 != null && l2 != null)
        {
            if(l1.val < l2.val)
            {
                tail.next = l1;
                l1 = l1.next;
            }
            else
            {
                tail.next = l2;
                l2 = l2.next;
            }
            tail = tail.next;
        }

        tail.next = l1 != null ? l1 : l2;

        return dummy.next;
    }
}
