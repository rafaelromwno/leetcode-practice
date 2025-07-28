# 🔢 Number of Steps to Reduce a Number to Zero – LeetCode Problem #1342

## 🧠 Problem Statement

Given an integer `num`, return the number of steps to reduce it to zero.

In one step, you can:
- If the current number is even, divide it by 2.
- If the current number is odd, subtract 1.

---

## ✅ Example

```csharp
Input: num = 14
Output: 6

Explanation:
Step 1) 14 is even; divide by 2 → 7  
Step 2) 7 is odd; subtract 1 → 6  
Step 3) 6 is even; divide by 2 → 3  
Step 4) 3 is odd; subtract 1 → 2  
Step 5) 2 is even; divide by 2 → 1  
Step 6) 1 is odd; subtract 1 → 0  
```

---

## 💡 Approach 1: Normal Arithmetic

```csharp
public class Solution {
    public int NumberOfSteps(int num) {
        int steps = 0;
        while (num > 0) {
            if (num % 2 == 0)
                num /= 2;
            else
                num--;
            steps++;
        }
        return steps;
    }
}
```

---

## ⚡ Approach 2: Bitwise Optimization

We can replace:
- `num % 2 == 0` with `(num & 1) == 0`
- `num /= 2` with `num >>= 1`

### ✅ Bitwise Version in C#

```csharp
public class Solution {
    public int NumberOfSteps(int num) {
        int steps = 0;
        while (num > 0) {
            if ((num & 1) == 0)
                num >>= 1;  // Right shift: divide by 2
            else
                num--;      // Subtract 1 if odd
            steps++;
        }
        return steps;
    }
}
```

---

## 🕒 Time and Space Complexity

- **Time Complexity:** O(log n)
- **Space Complexity:** O(1)

---

## 🧪 Quick Test

```csharp
int num = 14;
var solution = new Solution();
Console.WriteLine(solution.NumberOfSteps(num));
```

---

## 🔗 Source

LeetCode – [Number of Steps to Reduce a Number to Zero](https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/)