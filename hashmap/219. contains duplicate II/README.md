# Contains Duplicate II – LeetCode Problem #219

## 🧠 Problem Statement

Given an integer array `nums` and an integer `k`, return `true` if there are **two distinct indices** `i` and `j` in the array such that `nums[i] == nums[j]` and `abs(i - j) <= k`.

**Constraints:**
- `1 <= nums.length <= 10⁵`
- `-10⁹ <= nums[i] <= 10⁹`
- `0 <= k <= 10⁵`

## ✅ Example

```text
Input: nums = [1, 2, 3, 1], k = 3  
Output: true

Explanation: nums[0] == nums[3] and abs(0 - 3) = 3 ≤ k
```

---

## 💡 Approach

I used a hash map (`Dictionary<int, int>`) to store each number and its **most recent index**.  
As we iterate through the array, we check:
- If the current number exists in the dictionary and
- If the difference between the current index and the stored index is less than or equal to `k`.

If both are true, we return `true`. Otherwise, we update the number's index in the dictionary.

This ensures we always track the nearest index of each duplicate.

---

## 🕒 Time and Space Complexity

- **Time Complexity:** O(n), where n is the length of the array  
- **Space Complexity:** O(n), for storing up to n elements in the dictionary

---

## 🔗 Source

[LeetCode – Contains Duplicate II](https://leetcode.com/problems/contains-duplicate-ii/)
