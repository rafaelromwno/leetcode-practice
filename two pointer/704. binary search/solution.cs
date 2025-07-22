public class Solution {
    public int Search(int[] nums, int target) {

        int size = nums.Length - 1;
        int left = 0; // left = índice referente ao começo
        int right = size; // // right = índice referente ao fim
        int mid;

        while(left <= right){

            mid = left + (right - left) / 2; // evita integer overflow

            if(nums[mid] == target) 
                return mid;

            if(nums[mid] < target){
                left = mid + 1; // encurta o lado esquerdo
            }
            else{
                right = mid - 1; // encurta o lado direito
            }

        }

        return -1;
    }
}
