// Original: [1, 3, 5, 2, 1, 3, 1]
// Ordenado: [1, 1, 1, 2, 3, 3, 5]
// Resultado: 4

public class Solution {
    public int MaximizeGreatness(int[] nums) {
         // ordena os números em ordem crescente O(N log N)
        Array.Sort(nums);
      
        int changes = 0;
        int j = 0; // ponteiro para comparar com os elementos "originais"

        // percorre os elementos ordenados com um segundo ponteiro
        for (int i = 0; i < nums.Length; i++)
        {
            if ( nums[j] < nums[i] )
            {
                // encontramos um elemento que pode ser trocado 
                changes++;
                j++;
            }
        }

        return changes;

    }
}
