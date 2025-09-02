public class Solution {
    public bool IsPalindrome(int x) {
        
        string original = x.ToString();
        char[] array = original.ToCharArray();

        int left = 0;
        int right = array.Length - 1;

        while (left < right) 
        {
            if (array[left] != array[right])
                return false;

            left++;
            right--;
        }

        return true;
    }
}
