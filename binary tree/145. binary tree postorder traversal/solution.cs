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
    public IList<int> PostorderTraversal(TreeNode root) {
        
        IList<int> result = [];
        PostorderRecursive(root, result);
        return result;

    }

    public void PostorderRecursive(TreeNode self, IList<int> result){

        if (self != null){

            PostorderRecursive(self.left, result);
            PostorderRecursive(self.right, result);
            result.Add(self.val);

        }
    }
}