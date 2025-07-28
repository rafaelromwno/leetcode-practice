# 🧩 Missing Number – LeetCode Problem #268 (Resolução com XOR em C#)

## 🧠 Problem Statement

Dado um array contendo `n` números distintos no intervalo `[0, n]`, encontre o **único número que está faltando**.

### Constraints:
- 1 <= nums.length <= 10⁴
- `nums` contém números distintos de `0` até `n`
- Apenas um número está faltando

---

## ✅ Example

```csharp
Input:  nums = [3, 0, 1]
Output: 2
```

---

## 💡 Approach: XOR

Propriedades do XOR (`^`):

- `a ^ a = 0`
- `a ^ 0 = a`
- XOR é comutativo e associativo.

### Lógica:

- Faça XOR de todos os índices de `0` até `n`.
- Faça XOR com todos os valores do array.
- Os valores que aparecem duas vezes se cancelam e sobra apenas o número ausente.

---

## 🕒 Time and Space Complexity

- **Tempo:** O(n)
- **Espaço:** O(1)

---

## 🧪 Quick Test

```csharp
int[] nums = {3, 0, 1};
var solution = new Solution();
Console.WriteLine($"Resultado final: {solution.MissingNumber(nums)}");
```

---

## 🔗 Source

LeetCode – [Missing Number](https://leetcode.com/problems/missing-number/)
