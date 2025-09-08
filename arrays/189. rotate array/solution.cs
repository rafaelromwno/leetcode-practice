/*
rotacionar à direita por k é o mesmo que:
    -reverter todo o array.
    -reverter os primeiros k elementos.
    -reverter os n - k elementos restantes.
*/

public class Solution {
    public void Rotate(int[] nums, int k) {
        
        int size = nums.Length;

        // prevenir um ciclo desnecessario
        k %= size;

        // se nenhuma rotação for aplicada OU número de itens do array é menor ou igual a 1 -> saia da funcao
        if (k == 0 || n <= 1)
            return;

        // reverter todo o array
        Reverse(nums, 0, size - 1);

        // reverter os primeiros k elementos
        Reverse(nums, 0, k - 1);
        
        // reverter os n - k elementos restantes
        Reverse(nums, k, size - 1);

    }

    public void Reverse(int[] array, int start, int end)
    {
        while (start < end)
        {
            // swap
            int temp = array[end];
            array[end] = array[start];
            array[start] = temp;

            // moving the pointers
            start++;
            end--;

        }
    }
}
