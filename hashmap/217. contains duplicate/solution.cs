public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        
        Dictionary<int, int> map = new Dictionary<int, int>();
        int size = nums.Length;

        for (int i = 0; i < size; i++)
        {
            if (map.ContainsKey(nums[i]))
                return true;

            map.Add(nums[i], i);            
        }

        return false;

    }
}
