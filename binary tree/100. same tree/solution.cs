/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool IsSameTree(TreeNode p, TreeNode q) {
        
        // se ambos são nulos, são iguais
        if (p == null && q == null) return true;

        // se apenas um deles é nulo, são diferentes
        if (p == null || q == null) return false;

        // se os valores são diferentes, são diferentes
        if (p.val != q.val) return false;

        // verifica recursivamente as subárvores esquerda e direita
        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);      
        
    }
}
