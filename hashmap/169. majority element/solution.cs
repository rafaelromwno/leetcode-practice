public class Solution {
    public int MajorityElement(int[] nums) {
        int size = nums.Length;
        int majority = size / 2;
        Dictionary<int, int> map = new Dictionary<int, int>();

        for(int i = 0; i < size; i++)
        {
            if (map.ContainsKey(nums[i]))
                map[nums[i]]++;
            else
                map[nums[i]] = 1;

            if (map[nums[i]] > majority)
            return nums[i];
                
        }

        return -1;
    }
}
