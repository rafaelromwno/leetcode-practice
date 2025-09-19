public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        //temperatures = [30,60,90]
        int size = temperatures.Length;
        int[] ans = new int[temperatures.Length];

        for (int i = 0; i < size; i++)
        {
            for (int j = i + 1; j < size; j++)
            {
                if (temperatures[i] < temperatures[j])
                {
                    ans[i] = j - i;
                    break;
                }
            }
        }

        return ans;
    }
}
// Time Limit Exceeded
//47 / 48 testcases passed