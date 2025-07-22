# 🔍 Binary Search em C# com Prevenção de Integer Overflow

Este repositório demonstra uma implementação segura da **busca binária** (binary search) em C#, com explicação detalhada sobre o risco de **estouro de inteiro (integer overflow)** e como evitá-lo.

---

## 🧠 O que é Binary Search?

A **busca binária** é um algoritmo eficiente para encontrar um valor em uma lista ordenada, reduzindo o espaço de busca pela metade a cada iteração.

### Requisitos:
- O array precisa estar **ordenado**.
- O algoritmo tem complexidade **O(log n)**.

---

## 💥 Risco de Overflow

Ao calcular o índice central com:

```csharp
int mid = (left + right) / 2;
```

Há risco de **estouro de inteiro** (`integer overflow`) se `left` e `right` forem muito grandes.

### Exemplo perigoso:

```csharp
int left = 2_000_000_000;
int right = 2_100_000_000;

int mid = (left + right) / 2; // ❌ Pode causar overflow!
```

Neste caso, `left + right = 4_100_000_000`, que **ultrapassa o limite do tipo `int`** em C# (`int.MaxValue = 2_147_483_647`).

---

## ✅ Forma segura de calcular `mid`

Para evitar overflow:

```csharp
int mid = left + (right - left) / 2;
```

Essa forma calcula a distância e só então soma a metade ao `left`, **garantindo que não haja soma de dois valores potencialmente grandes**.

---

## 🧪 Implementação segura de Binary Search em C#

```csharp
public class BinarySearch
{
    public static int Search(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            // Cálculo seguro para evitar overflow
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
                return mid;
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1; // Não encontrado
    }
}
```

---

## 📌 Exemplo de uso

```csharp
class Program
{
    static void Main()
    {
        int[] numbers = { 1, 3, 5, 7, 9, 11, 13, 15 };
        int index = BinarySearch.Search(numbers, 7);

        Console.WriteLine(index >= 0
            ? $"Elemento encontrado no índice {index}"
            : "Elemento não encontrado.");
    }
}
```

---

## 📈 Vantagens da busca binária

- Rápida para grandes arrays ordenados
- O(log n) comparações
- Simples de implementar com segurança

---

## 🛡️ Dica final

Sempre use:

```csharp
int mid = left + (right - left) / 2;
```

Essa prática evita **bugs difíceis de detectar** causados por overflow silencioso em linguagens como C e C#.

---

## 🧾 Licença

Este projeto é livre para uso educacional.
