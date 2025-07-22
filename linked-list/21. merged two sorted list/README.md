# LeetCode 21 - Merge Two Sorted Lists

**Problem Link:** [https://leetcode.com/problems/merge-two-sorted-lists](https://leetcode.com/problems/merge-two-sorted-lists)

## Problem Description

You are given the heads of two sorted linked lists `list1` and `list2`.

Merge the two lists into one **sorted** list. The list should be made by splicing together the nodes of the first two lists.

Return the head of the merged linked list.

### Example

```
Input: list1 = [1,2,4], list2 = [1,3,4]
Output: [1,1,2,3,4,4]
```

## Approach

I used a **dummy node** to simplify edge case handling and a pointer `tail` to build the new list step-by-step:

1. Create a dummy node to act as the head of the new list.
2. Compare values of `list1` and `list2`:
   - Append the smaller node to `tail.next`.
   - Move the pointer (`list1` or `list2`) ahead.
   - Move the `tail` pointer forward.
3. After the loop, attach the remainder of either list (one may still contain nodes).
4. Return `dummy.next` (skipping the dummy node).

## Abordagem - ptbr
Usei um **nó sentinela (dummy node)** para simplificar o tratamento de casos extremos e um ponteiro `tail` para construir a nova lista passo a passo:

1. Criamos um nó sentinela que atuará como cabeça da nova lista.
2. Comparamos os valores de `list1` e `list2`:
    - Anexamos o nó com menor valor ao tail.next.
    - Avançamos o ponteiro (`list1` ou `list2`) correspondente.
    - Movemos o ponteiro `tail` para frente.
3. Após o laço, anexamos o restante de uma das listas (caso ainda tenha nós).
4. Retornamos `dummy.next` (ignorando o nó sentinela).

## Time and Space Complexity

- **Time Complexity:** O(n + m), where n and m are the lengths of `list1` and `list2`.
- **Space Complexity:** O(1), since we reuse existing nodes and only use constant extra space.

## Notes

- This technique is commonly used in **merge sort** and other problems involving sorted lists.
- Using a dummy node avoids handling special cases when initializing the merged list.
