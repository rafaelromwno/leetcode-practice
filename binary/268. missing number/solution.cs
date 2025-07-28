public class Solution {
    public int MissingNumber(int[] nums) {
        
        int size = nums.Length;
        int xor = size;

        for(int i = 0; i < size; i++)
        {
            xor ^= i ^ nums[i];
        }

        return xor;

    }
}
