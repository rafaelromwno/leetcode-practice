// DFS – Depth-First Search (pré-ordem)

// a) recursivo (pré-ordem: raiz → esquerda → direita)
public void DFS(TreeNode root) {
    if (root == null) return;

    Console.Write(root.val + " ");
    DFS(root.left);
    DFS(root.right);
}

// a) recursivo (pré-ordem: raiz → esquerda → direita)
public void DFS_Iterativo(TreeNode root) {
    if (root == null) return;

    Stack<TreeNode> stack = new Stack<TreeNode>();
    stack.Push(root);

    while (stack.Count > 0) {
        TreeNode current = stack.Pop();
        Console.Write(current.val + " ");

        // primeiro direita, depois esquerda (para que esquerda saia primeiro da pilha)
        if (current.right != null)
            stack.Push(current.right);
        if (current.left != null)
            stack.Push(current.left);
    }
}

