# LeetCode 876 — Middle of the Linked List

## 🧩 Problem Description

**LeetCode Problem:** [876. Middle of the Linked List](https://leetcode.com/problems/middle-of-the-linked-list/)

Given the head of a singly linked list, return the middle node of the linked list.

If there are two middle nodes, return the second middle node.

### 🔒 Constraints:

- The number of nodes in the list is in the range `[1, 100]`.
- `1 <= Node.val <= 100`

### 🧪 Example:

**Input:**

```
head = [1, 2, 3, 4, 5]
```

**Output:**

```
3
```

**Input:**

```
head = [1, 2, 3, 4, 5, 6]
```

**Output:**

```
4
```

---

## 🧠 Approach: Two Pointers (Fast and Slow)

This solution uses the **two-pointer technique**:

- `slow` pointer moves one step at a time.
- `fast` pointer moves two steps at a time.

When `fast` reaches the end of the list, `slow` will be at the middle.

---

## 📈 Complexity Analysis

| Type             | Complexity   |
|------------------|--------------|
| Time Complexity  | `O(n)` — Traverse half the list |
| Space Complexity | `O(1)` — Constant space usage |

---

## 📌 Summary

The fast and slow pointer technique allows finding the middle of a linked list in a single traversal, with optimal time and space performance.
