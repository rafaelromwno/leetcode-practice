public class Solution {
    public int FindMaxK(int[] nums) {
      
        HashSet<int> map = new HashSet<int>(nums);// um hashset armazena apenas valores únicos para checar existência, enquanto um dictionary armazena pares chave–valor
        int max = -1;

        foreach (int num in nums)
        {
            if (num > 0 && map.Contains(-num))
                max = Math.Max(max, num);
        }

        return max;
        
    }
}

