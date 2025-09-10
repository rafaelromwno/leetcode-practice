# Longest Bitonic Subsequence (Maior Subsequência Bitônica)

## Descrição do Problema

Uma subsequência bitônica é uma sequência que:

1. Primeiro cresce (estritamente crescente);
2. Depois decresce (estritamente decrescente).

Exemplo: No array `[1, 11, 2, 10, 4, 5, 2, 1]`, a maior subsequência bitônica é `[1, 2, 10, 4, 2, 1]` com comprimento `6`.

O objetivo é encontrar o comprimento da maior subsequência bitônica.

---

## Lógica do Algoritmo

A ideia é dividir o problema em duas partes:

1. **LIS (Longest Increasing Subsequence)**

   * Para cada posição `i`, calculamos o tamanho da maior subsequência crescente que termina em `i`.
   * Guardamos isso em `longestIncreasing[i]`.

2. **LDS (Longest Decreasing Subsequence)**

   * Para cada posição `i`, calculamos o tamanho da maior subsequência decrescente que começa em `i`.
   * Guardamos isso em `longestDecreasing[i]`.

3. **Combinação**

   * Para cada posição `i`, a subsequência bitônica com "pico" em `i` terá comprimento:
     `longestIncreasing[i] + longestDecreasing[i] - 1`
     (subtraímos 1 porque `arr[i]` foi contado duas vezes).

4. **Resposta Final**

   * O maior valor calculado entre todos os índices será o comprimento da maior subsequência bitônica.

---

## Código em C\#

```csharp
using System;

class Program
{
    static int LongestBitonicSubsequence(int[] numbers)
    {
        int size = numbers.Length;

        int[] longestIncreasing = new int[size];
        int[] longestDecreasing = new int[size];

        for (int index = 0; index < size; index++)
        {
            longestIncreasing[index] = 1;
            longestDecreasing[index] = 1;
        }

        // LIS
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

        // LDS
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
```

---

## Exemplo de Execução

Para `numbers = [1, 11, 2, 10, 4, 5, 2, 1]`:

```
Maior subsequência bitônica tem tamanho: 7
```

---

## Complexidade

* **Tempo:** `O(n^2)` (dois loops aninhados para LIS e LDS).
* **Espaço:** `O(n)` (vetores auxiliares `longestIncreasing` e `longestDecreasing`).

---

## Nível de Dificuldade

* **Intermediário/Avançado**

  * Requer conhecimento de programação dinâmica (DP).
  * Envolve decomposição do problema em LIS e LDS e combinação.

---

## Conclusão

O algoritmo da **Maior Subsequência Bitônica** utiliza **programação dinâmica** para calcular LIS e LDS, combinando-os para encontrar o comprimento máximo.
É um problema clássico para entrevistas, testando habilidade de **reutilização de resultados parciais** e **análise de subproblemas**.

```
```
