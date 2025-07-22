# LeetCode 141 — Linked List Cycle

## 🧩 Problem Description

**LeetCode Problem:** [141. Linked List Cycle](https://leetcode.com/problems/linked-list-cycle/)

Given the head of a linked list, determine if the linked list has a cycle in it.

There is a cycle in a linked list if there is some node in the list that can be reached again by continuously following the `next` pointer.

Return `true` if there is a cycle in the linked list. Otherwise, return `false`.

### 🔒 Constraints:

- The number of the nodes in the list is in the range `[0, 10^4]`.
- `-10^5 <= Node.val <= 10^5`
- `pos` is `-1` or a valid index in the list

---

## 🧠 Approach: Two Pointers (Floyd's Cycle Detection)

This solution uses **Floyd's Cycle Detection Algorithm**, also known as the **Tortoise and Hare** algorithm:

- Use two pointers (`slow` and `fast`).
- `slow` moves 1 step at a time.
- `fast` moves 2 steps at a time.
- If a cycle exists, the two pointers will eventually meet inside the cycle.
- If the list has an end (`fast` becomes null), then no cycle exists.

---

## 📈 Complexity Analysis

| Type             | Complexity   |
|------------------|--------------|
| Time Complexity  | `O(n)` — At most `n` steps |
| Space Complexity | `O(1)` — Constant space |

---

## 🧪 Additional Test Cases

```csharp
Input: head = [3,2,0,-4], pos = 1
Output: true

Input: head = [1,2], pos = 0
Output: true

Input: head = [1], pos = -1
Output: false
```

---

## 📌 Summary

Floyd's algorithm is a highly efficient method to detect cycles in a linked list using constant memory. It guarantees detection if a cycle exists, and is optimal in both time and space.
