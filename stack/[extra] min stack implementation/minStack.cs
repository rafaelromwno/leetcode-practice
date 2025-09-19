using System;
using System.Collections.Generic;

public class MinStack
{
    private Stack<int> stack;
    private Stack<int> minStack;

    public MinStack()
    {
        stack = new Stack<int>();
        minStack = new Stack<int>();
    }

    // adiciona um elemento à pilha
    public void Push(int value)
    {
        stack.Push(value);

        // se minstack estiver vazia ou o novo valor for menor ou igual ao topo, inclua no topo de minstack
        if (minStack.Count == 0 || value <= minStack.Peek())
            minStack.Push(value);
    }

    // remove o elemento do topo
    public void Pop()
    {
        if (stack.Count == 0) return;

        int removed = stack.Pop();

        // se o item removido for igual ao topo da minstack (menor valor atual), remova de minstack tambem
        if (removed == minStack.Peek())
            minStack.Pop();
    }

    // retorna o elemento do topo
    public int Top()
    {
        if (stack.Count == 0) throw new InvalidOperationException("Stack is empty.");

        return stack.Peek();
    }

    // retorna o menor elemento da pilha
    public int GetMin()
    {
        if (minStack.Count == 0) throw new InvalidOperationException("Stack is empty.");

        return minStack.Peek();
    }
}