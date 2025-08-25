public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public void BFS(TreeNode root) {
    if (root == null) return;

    Queue<TreeNode> queue = new Queue<TreeNode>();
    queue.Enqueue(root);

    while (queue.Count > 0) {
        TreeNode current = queue.Dequeue();
        Console.Write(current.val + " ");

        if (current.left != null)
            queue.Enqueue(current.left);

        if (current.right != null)
            queue.Enqueue(current.right);
    }
}

//     1
//    / \
//   2   3
//  / \
// 4   5
// A BFS imprimiria: 1 2 3 4 5