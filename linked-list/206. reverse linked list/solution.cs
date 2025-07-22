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
    public ListNode ReverseList(ListNode head) {

        ListNode previous_node = null;

        // percorre a lista enquanto houver nós
        while (head != null) {

            // armazena o próximo nó antes de alterar a referência
            ListNode nextNode = head.next;

            // inverte a referência do nó atual
            head.next = previousNode;

            // avança os ponteiros
            previousNode = head;
            head = nextNode;
        }

        // retorna o novo início da lista (último nó da lista original)
        return previousNode;
    }
}
