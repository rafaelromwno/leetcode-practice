public class Solution {
    public string ReverseWords(string s) {
      
        StringBuilder res = new StringBuilder();
        int left = 0;
        int right = 0;
        int length = s.Length;

        while (right < length) {
            if (s[right] != ' ') {
                right++;
            } else {
                // inverte a palavra atual e adiciona (append)
                for (int i = right - 1; i >= left; i--) {
                    res.Append(s[i]);
                }
                res.Append(' ');
                right++;
                left = right;
            }
        }

        // inverte a ultima palavra
        for (int i = right - 1; i >= left; i--) {
            res.Append(s[i]);
        }

        return res.ToString();
    }
}
