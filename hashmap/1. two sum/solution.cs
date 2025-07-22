public class Solution {
    public int[] TwoSum(int[] nums, int target) {
      
        // criação do dicionário para armazenar os números e seus índices
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
          
            int complement = target - nums[i];

            // se o complemento estiver no mapa, encontramos a solução
            if (map.ContainsKey(complement)) {
                // retorna os índices do número encontrado e o índice atual
                return new int[] { map[complement], i };
            }

            // se não estiver no mapa, adiciona o número atual e seu índice
            map[nums[i]] = i;
        }

        // se não encontrar nenhuma solução, retorna null
        throw new Exception("No solution found");
    }
}
