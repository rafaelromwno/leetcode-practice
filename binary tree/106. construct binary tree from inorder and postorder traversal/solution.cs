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
    private Dictionary<int, int> inorderIndex;

    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        inorderIndex = new Dictionary<int, int>();
        for (int i = 0; i < inorder.Length; i++) {
            inorderIndex[inorder[i]] = i;
        }

        return Build(postorder, 0, postorder.Length - 1, 0, inorder.Length - 1);
    }

    private TreeNode Build(int[] postorder, int postStart, int postEnd, int inStart, int inEnd) {
        if (postStart > postEnd || inStart > inEnd)
            return null;

        int rootVal = postorder[postEnd];
        TreeNode root = new TreeNode(rootVal);

        int index = inorderIndex[rootVal];
        int leftSize = index - inStart;

        root.left = Build(postorder, postStart, postStart + leftSize - 1, inStart, index - 1);
        root.right = Build(postorder, postStart + leftSize, postEnd - 1, index + 1, inEnd);

        return root;
    }
}