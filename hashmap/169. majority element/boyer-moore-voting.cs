public class Solution {
    public int MajorityElement(int[] nums) {
        int size = nums.Length;
        int candidate = 0;
        int counter = 0;

        for(int i = 0; i < size; i++)
        {
            if (counter == 0)
                candidate = nums[i];

            if (nums[i] == candidate)
                counter++;
            else
                counter--;           
        }

        return candidate;
    }
}
