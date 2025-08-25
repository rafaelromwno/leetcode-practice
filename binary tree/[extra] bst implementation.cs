public class TreeNode
{
    public int Data;
    public TreeNode LeftChild;
    public TreeNode RightChild;

    public TreeNode(int data)
    {
        Data = data;
        LeftChild = null;
        RightChild = null;
    }
}

public class BinarySearchTree
{
    public TreeNode RootNode;

    public BinarySearchTree()
    {
        RootNode = null;
    }

    // Inserção recursiva
    public void Add(int data)
    {
        RootNode = AddRecursive(RootNode, data);
    }

    private TreeNode AddRecursive(TreeNode currentNode, int data)
    {
        if (currentNode == null)
            return new TreeNode(data);

        if (data < currentNode.Data)
            currentNode.LeftChild = AddRecursive(currentNode.LeftChild, data);
        else if (data > currentNode.Data)
            currentNode.RightChild = AddRecursive(currentNode.RightChild, data);

        return currentNode;
    }

    // Busca recursiva
    public bool Contains(int data)
    {
        return ContainsRecursive(RootNode, data);
    }

    private bool ContainsRecursive(TreeNode currentNode, int data)
    {
        if (currentNode == null) return false;
        if (currentNode.Data == data) return true;

        if (data < currentNode.Data)
            return ContainsRecursive(currentNode.LeftChild, data);
        else
            return ContainsRecursive(currentNode.RightChild, data);
    }

    // Remoção
    public void Delete(int data)
    {
        RootNode = DeleteRecursive(RootNode, data);
    }

    private TreeNode DeleteRecursive(TreeNode currentNode, int data)
    {
        if (currentNode == null) return null;

        if (data < currentNode.Data)
            currentNode.LeftChild = DeleteRecursive(currentNode.LeftChild, data);
        else if (data > currentNode.Data)
            currentNode.RightChild = DeleteRecursive(currentNode.RightChild, data);
        else
        {
            // Caso 1: nó folha
            if (currentNode.LeftChild == null && currentNode.RightChild == null)
                return null;

            // Caso 2: nó com apenas um filho
            if (currentNode.LeftChild == null)
                return currentNode.RightChild;
            else if (currentNode.RightChild == null)
                return currentNode.LeftChild;

            // Caso 3: nó com dois filhos
            currentNode.Data = FindMinValue(currentNode.RightChild);
            currentNode.RightChild = DeleteRecursive(currentNode.RightChild, currentNode.Data);
        }

        return currentNode;
    }

    private int FindMinValue(TreeNode currentNode)
    {
        int min = currentNode.Data;
        while (currentNode.LeftChild != null)
        {
            min = currentNode.LeftChild.Data;
            currentNode = currentNode.LeftChild;
        }
        return min;
    }

    // Percurso em ordem
    public void TraverseInOrder()
    {
        TraverseInOrderRecursive(RootNode);
        Console.WriteLine();
    }

    private void TraverseInOrderRecursive(TreeNode node)
    {
        if (node != null)
        {
            TraverseInOrderRecursive(node.LeftChild);
            Console.Write(node.Data + " ");
            TraverseInOrderRecursive(node.RightChild);
        }
    }

    public void TraversePreOrder()
    {
        TraversePreOrderRecursive(RootNode);
        Console.WriteLine();
    }

    private void TraversePreOrderRecursive(TreeNode node)
    {
        if (node != null)
        {
            Console.Write(node.Data + " ");
            TraversePreOrderRecursive(node.LeftChild);
            TraversePreOrderRecursive(node.RightChild);
        }
    }

    public void TraversePostOrder()
    {
        TraversePostOrderRecursive(RootNode);
        Console.WriteLine();
    }

    private void TraversePostOrderRecursive(TreeNode node)
    {
        if (node != null)
        {
            TraversePostOrderRecursive(node.LeftChild);
            TraversePostOrderRecursive(node.RightChild);
            Console.Write(node.Data + " ");
        }
    }

    // Percurso em largura (Level Order)
    public void TraverseLevelOrder()
    {
        if (RootNode == null) return;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(RootNode);

        while (queue.Count > 0)
        {
            TreeNode current = queue.Dequeue();
            Console.Write(current.Data + " ");

            if (current.LeftChild != null)
                queue.Enqueue(current.LeftChild);

            if (current.RightChild != null)
                queue.Enqueue(current.RightChild);
        }

        Console.WriteLine();
    }
}