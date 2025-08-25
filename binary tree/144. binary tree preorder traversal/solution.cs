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
    public IList<int> PreorderTraversal(TreeNode root) {
        IList<int> result = [];
        PreorderRecursive(root, result);
        return result;
    }

    public void PreorderRecursive(TreeNode self, IList<int> result){

        if (self != null){

            result.Add(self.val);
            PreorderRecursive(self.left, result);
            PreorderRecursive(self.right, result);
        }
    }
}