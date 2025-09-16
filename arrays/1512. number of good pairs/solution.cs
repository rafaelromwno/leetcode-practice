public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        int goodPairs = 0;
        int size = nums.Length;

        for (int i = 0; i < size; i++)
        {
            for (int j = i + 1; j < size; j++)
            {
                if (nums[i] == nums[j])
                    goodPairs++;
            }
        }
    
        return goodPairs;
    }
}

// Time: O(n²)
