/*
rotacionar à direita por k é o mesmo que:
    -reverter todo o array.
    -reverter os primeiros k elementos.
    -reverter os n - k elementos restantes.
*/

public class Solution {
    public void Rotate(int[] nums, int k) {
        
       int size = nums.Length;

        // avoid a cycle
       if (k > size)
        k %= size;

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
            // trocar
            int temp = array[end];
            array[end] = array[start];
            array[start] = temp;

            // movendo os ponteiros até se encontrarem
            start++;
            end--;

        }
    }
}
