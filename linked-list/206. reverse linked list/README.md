# LeetCode 206 — Reverse Linked List

## 🧩 Problem Description

**LeetCode Problem:** [206. Reverse Linked List](https://leetcode.com/problems/reverse-linked-list/)

Given the head of a singly linked list, reverse the list and return the reversed list.

### 🔒 Constraints:

- The number of nodes in the list is in the range `[0, 5000]`.
- `-5000 <= Node.val <= 5000`

### 🧪 Example:

**Input:**

```
head = [1, 2, 3, 4, 5]
```

**Output:**

```
[5, 4, 3, 2, 1]
```

---

## 🧠 Approach: Iterative Reversal

This solution uses an **iterative approach** with three pointers:

- `previousNode`: tracks the previously visited node.
- `currentNode` (initially `head`): the node being processed.
- `nextNode`: temporarily stores the next node before changing links.

The list is reversed in-place by re-pointing each node's `next` reference to its previous node.

---

## 🧾 Step-by-Step Logic

1. Initialize `previousNode` as `null` (end of the new list).
2. Traverse the list while `head` is not `null`.
3. For each node:
   - Store the next node (`nextNode = head.next`).
   - Reverse the link (`head.next = previousNode`).
   - Move `previousNode` and `head` one step forward.
4. When done, `previousNode` points to the new head of the reversed list.
5. Return `previousNode`.

## 📈 Complexity Analysis

| Type             | Complexity   |
|------------------|--------------|
| Time Complexity  | `O(n)` — Traverse all `n` nodes once |
| Space Complexity | `O(1)` — In-place reversal without extra memory |

---

## 📌 Summary

This solution provides a clean, in-place reversal of a singly linked list using an iterative method. It runs in linear time and uses constant space, making it optimal for this problem.
