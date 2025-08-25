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

    public IList<int> InorderTraversal(TreeNode root) {
        IList<int> result = [];
        InorderRecursive(root, result);
        return result;
    }

    public void InorderRecursive(TreeNode self, IList<int> result) {

        if(self != null){
            InorderRecursive(self.left, result);
            result.Add(self.val);
            InorderRecursive(self.right, result);
        }
        
    }
}