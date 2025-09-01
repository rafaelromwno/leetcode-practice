using System;
using System.Collections.Generic;

public class MinHeap {
    private List<int> heap;

    public MinHeap() {
        heap = new List<int>();
    }

    // retorna o índice do pai de um nó
    private int Parent(int i) => (i - 1) / 2;

    // retorna o índice do filho à esquerda de um nó
    private int LeftChild(int i) => 2 * i + 1;

    // retorna o índice do filho à direita de um nó
    private int RightChild(int i) => 2 * i + 2;

    // troca dois elementos na lista
    private void Swap(int i, int j) {
        int temp = heap[i];
        heap[i] = heap[j];
        heap[j] = temp;
    }

    // função para garantir que o heap esteja em ordem após inserir um novo elemento
    private void HeapifyUp(int index) {
        while (index > 0 && heap[Parent(index)] < heap[index]) {
            Swap(Parent(index), index);
            index = Parent(index);
        }
    }

    // função para garantir que o heap esteja em ordem após remover o topo
    private void HeapifyDown(int index) {
        int left = LeftChild(index);
        int right = RightChild(index);
        int largest = index;

        if (left < heap.Count && heap[left] > heap[largest]) {
            largest = left;
        }

        if (right < heap.Count && heap[right] > heap[largest]) {
            largest = right;
        }

        if (largest != index) {
            Swap(index, largest);
            HeapifyDown(largest);
        }
    }

    // função para adicionar um novo valor ao heap
    public void Insert(int value) {
        heap.Add(value);          // Adiciona o novo valor no final
        HeapifyUp(heap.Count - 1); // Reorganiza o heap a partir do novo valor
    }

    // função para remover o valor mínimo (raiz)
    public int RemoveMin() {
        if (heap.Count == 0) {
            throw new InvalidOperationException("Heap vazio");
        }

        int min = heap[0];
        heap[0] = heap[heap.Count - 1]; // move o último valor para a raiz
        heap.RemoveAt(heap.Count - 1);   // remove o último valor

        // reorganiza o heap
        HeapifyDown(0);

        return min;
    }

    // retorna o valor mínimo (raiz)
    public int Peek() {
        if (heap.Count == 0) {
            throw new InvalidOperationException("Heap vazio");
        }
        return heap[0];
    }

    // apenas para visualização
    public void PrintHeap() {
        foreach (var val in heap) {
            Console.Write(val + " ");
        }
        Console.WriteLine();
    }
}

class Program {
    static void Main() {
        MinHeap minHeap = new MinHeap();
        
        // inserir elementos
        minHeap.Insert(10);
        minHeap.Insert(20);
        minHeap.Insert(5);
        minHeap.Insert(8);
        minHeap.Insert(3);

        // imprimir o Heap
        Console.WriteLine("Min-Heap:");
        minHeap.PrintHeap();

        // remover o valor mínimo
        Console.WriteLine($"Removido: {minHeap.RemoveMin()}");

        // imprimir após remoção
        Console.WriteLine("Após remover o mínimo:");
        minHeap.PrintHeap();

        // verificar o topo (valor mínimo)
        Console.WriteLine($"Topo (mínimo): {minHeap.Peek()}");
    }
}
