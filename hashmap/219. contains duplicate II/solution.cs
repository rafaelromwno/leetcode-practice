public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {

        // dicionário para armazenar o número e o seu índice mais recente
        Dictionary<int, int> map = new Dictionary<int, int>();
        int size = nums.Length;

        for (int i = 0; i < size; i++) {

            // se o número já foi visto e a diferença entre os índices é menor ou igual a k
            if (map.ContainsKey(nums[i]) && i - map[nums[i]] <= k)
                return true;

            // atualiza (ou adiciona) o número com o índice atual
            map[nums[i]] = i;
        }

        return false;
    }
}
