using System;

class Program
{
    static int LongestBitonicSubsequence(int[] numbers)
    {
        int size = numbers.Length;

        // LIS[i] = tamanho da maior subsequência crescente terminando em i
        int[] longestIncreasing = new int[size];
        // LDS[i] = tamanho da maior subsequência decrescente começando em i
        int[] longestDecreasing = new int[size];

        // inicializa todos com 1 (cada número sozinho já é subsequência de tamanho 1)
        for (int index = 0; index < size; index++)
        {
            longestIncreasing[index] = 1;
            longestDecreasing[index] = 1;
        }

        // calcula LIS (da esquerda pra direita)
        for (int current = 1; current < size; current++)
        {
            for (int previous = 0; previous < current; previous++)
            {
                if (numbers[current] > numbers[previous] && 
                    longestIncreasing[current] < longestIncreasing[previous] + 1)
                {
                    longestIncreasing[current] = longestIncreasing[previous] + 1;
                }
            }
        }

        // calcula LDS (da direita pra esquerda)
        for (int current = size - 2; current >= 0; current--)
        {
            for (int next = size - 1; next > current; next--)
            {
                if (numbers[current] > numbers[next] && 
                    longestDecreasing[current] < longestDecreasing[next] + 1)
                {
                    longestDecreasing[current] = longestDecreasing[next] + 1;
                }
            }
        }

        // encontra o maior valor (LIS[i] + LDS[i] - 1)
        int maxLength = 0;
        for (int index = 0; index < size; index++)
        {
            maxLength = Math.Max(maxLength, longestIncreasing[index] + longestDecreasing[index] - 1);
        }

        return maxLength;
    }

    static void Main(string[] args)
    {
        int[] numbers = { 1, 11, 2, 10, 4, 5, 2, 1 };

        Console.WriteLine("Maior subsequência bitônica tem tamanho: " +
                          LongestBitonicSubsequence(numbers));
    }
}
