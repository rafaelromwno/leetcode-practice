public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution {
  
    public ListNode SortList(ListNode head) {

        // caso-base
        if (head == null || head.next == null) // o head == null garante que chamadas com listas vazias não causem erro e sejam tratadas como listas já ordenadas.
            return head;

        // divide a lista em duas partes
        ListNode middle = GetMiddle(head);
        ListNode right = middle.next;
        middle.next = null;

        // recursivamente ordena as metades
        ListNode leftSorted = SortList(head);
        ListNode rightSorted = SortList(right);

        // mescla as duas metades ordenadas
        return Merge(leftSorted, rightSorted);
    }

    // função para encontrar o meio da lista (técnica slow/fast pointer)
    private ListNode GetMiddle(ListNode head) {
        ListNode slow = head;
        ListNode fast = head.next;

        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }

        return slow;
    }

    // função para mesclar duas listas ordenadas
    private ListNode Merge(ListNode l1, ListNode l2) {
        ListNode dummy = new ListNode(0);
        ListNode tail = dummy;

        while (l1 != null && l2 != null) {
            if (l1.val < l2.val) {
                tail.next = l1;
                l1 = l1.next;
            } else {
                tail.next = l2;
                l2 = l2.next;
            }
            tail = tail.next;
        }

        // conecta o restante da lista (se houver)
        tail.next = l1 != null ? l1 : l2;

        return dummy.next;
    }
}
