using System;
using System.Collections.Generic;

public class Stack<T> {
    private List<T> stack;

    public Stack() {
        stack = new List<T>();
    }

    // adiciona um elemento no topo da pilha
    public void Push(T value) {
        stack.Add(value);
    }

    // remove e retorna o topo da pilha
    public T Pop() {
        if (IsEmpty()) {
            throw new InvalidOperationException("A pilha está vazia");
        }

        // pega o último elemento (topo) e o remove
        T top = stack[stack.Count - 1];
        stack.RemoveAt(stack.Count - 1);
        return top;
    }

    // retorna o topo da pilha sem removê-lo
    public T Peek() {
        if (IsEmpty()) {
            throw new InvalidOperationException("A pilha está vazia");
        }

        return stack[stack.Count - 1];
    }

    // verifica se a pilha está vazia
    public bool IsEmpty() {
        return stack.Count == 0;
    }

    // apenas para exibir os elementos da pilha
    public void PrintStack() {
        foreach (var item in stack) {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

class Program {
    static void Main() {
        // criando uma pilha de inteiros
        Stack<int> pilha = new Stack<int>();

        // adicionando elementos na pilha
        pilha.Push(10);
        pilha.Push(20);
        pilha.Push(30);

        // imprimindo a pilha
        Console.WriteLine("Pilha após inserção:");
        pilha.PrintStack();

        // verificando o topo
        Console.WriteLine($"Topo da pilha: {pilha.Peek()}");

        // removendo o topo
        Console.WriteLine($"Removido da pilha: {pilha.Pop()}");

        // imprimindo após a remoção
        Console.WriteLine("Pilha após remoção:");
        pilha.PrintStack();

        // verificando se a pilha está vazia
        Console.WriteLine($"A pilha está vazia? {pilha.IsEmpty()}");
    }
}