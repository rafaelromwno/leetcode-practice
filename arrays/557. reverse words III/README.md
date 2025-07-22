# Reverse Words in a String III – LeetCode Problem #557

## 🧠 Problem Statement

Given a string `s`, reverse the order of characters in each word within a sentence while still preserving whitespace and the initial word order.

**Constraints:**
- `1 <= s.length <= 5 * 10⁴`
- `s` contains printable ASCII characters.
- `s` does not contain leading or trailing spaces.
- There is exactly one space between words.

## ✅ Example

```text
Input: s = "Let's take LeetCode contest"
Output: "s'teL ekat edoCteeL tsetnoc"
```

---

## 💡 Approach

We iterate through the string using two pointers `left` and `right`:
- Expand `right` until we hit a space.
- Reverse the word between `left` and `right - 1`.
- Append the reversed word to the result string.
- Move the pointers to the start of the next word.

This is repeated until the end of the string, with a final word handled after the loop.

---

## 🕒 Time and Space Complexity

- **Time Complexity:** O(n), where n is the length of the string  
- **Space Complexity:** O(n), for the result string

---

## 🔗 Source

[LeetCode – Reverse Words in a String III](https://leetcode.com/problems/reverse-words-in-a-string-iii/)
