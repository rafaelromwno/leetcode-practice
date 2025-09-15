using System;
using System.Collections;

public class BloomFilter
{
    private readonly int _size; // tamanho do vetor de bits
    private readonly int _hashCount; // número de funções hash
    private readonly BitArray _bitArray; // vetor de bits para armazenar os valores

    // construtor para inicializar o bloom filter com o tamanho e número de funções hash
    public BloomFilter(int size, int hashCount)
    {
        _size = size;
        _hashCount = hashCount;
        _bitArray = new BitArray(size); // inicializa o vetor de bits com valores false (0)
    }

    // função hash 1 simples (baseada na soma dos valores dos caracteres)
    private int Hash1(string value)
    {
        int hash = 0;
        foreach (var c in value)
        {
            hash = (hash * 31 + c) % _size; // multiplicação e soma, seguido de módulo para limitar o tamanho do vetor
        }
        return hash;
    }

    // função hash 2 simples (método diferente para gerar hashes distintos)
    private int Hash2(string value)
    {
        int hash = 0;
        foreach (var c in value)
        {
            hash = (hash * 17 + c) % _size; // outro tipo de combinação de multiplicação e soma
        }
        return hash;
    }

    // função hash 3 simples (método baseado em uma multiplicação diferente)
    private int Hash3(string value)
    {
        int hash = 0;
        foreach (var c in value)
        {
            hash = (hash * 13 + c) % _size; // usando um número primo diferente para multiplicação
        }
        return hash;
    }

    // função para adicionar um item ao bloom filter
    public void Add(string value)
    {
        // calcula as posições dos bits a serem marcados como '1' para o valor
        int hash1 = Hash1(value);
        int hash2 = Hash2(value);
        int hash3 = Hash3(value);

        // marca as posições no vetor de bits como '1'
        _bitArray[hash1] = true;
        _bitArray[hash2] = true;
        _bitArray[hash3] = true;
    }

    // função para verificar se um item está presente no bloom filter
    public bool Contains(string value)
    {
        // calcula as posições dos bits para o valor a ser verificado
        int hash1 = Hash1(value);
        int hash2 = Hash2(value);
        int hash3 = Hash3(value);

        // verifica se as posições calculadas estão marcadas como '1'
        return _bitArray[hash1] && _bitArray[hash2] && _bitArray[hash3];
    }

    // método para exibir o vetor de bits (para fins de debug)
    public void DisplayBitArray()
    {
        for (int i = 0; i < _bitArray.Count; i++)
        {
            Console.Write(_bitArray[i] ? "1" : "0");
        }
        Console.WriteLine();
    }
}

public class Program
{
    public static void Main()
    {
        // criação de um bloom filter com 10 posições e 3 funções hash
        BloomFilter bloomFilter = new BloomFilter(10, 3);

        // adicionando elementos ao bloom filter
        bloomFilter.Add("apple");
        bloomFilter.Add("banana");
        bloomFilter.Add("cherry");

        // exibindo o vetor de bits
        Console.WriteLine("Bit array após adicionar elementos:");
        bloomFilter.DisplayBitArray();

        // verificando a presença de elementos
        Console.WriteLine($"'apple' está no filtro? {bloomFilter.Contains("apple")}");
        Console.WriteLine($"'banana' está no filtro? {bloomFilter.Contains("banana")}");
        Console.WriteLine($"'cherry' está no filtro? {bloomFilter.Contains("cherry")}");
        Console.WriteLine($"'orange' está no filtro? {bloomFilter.Contains("orange")}");
    }
}