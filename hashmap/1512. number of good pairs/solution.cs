public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        int goodPairs = 0;
        Dictionary<int, int> freq = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (freq.ContainsKey(num))
            {
                goodPairs += freq[num];
                freq[num]++;
            }
            else
                freq[num] = 1;
        }

        return goodPairs;
    }
}

// Time: O(n)
