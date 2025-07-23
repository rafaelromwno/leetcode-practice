public int[] BubbleSort(int[] nums) 
{
    int size = nums.Length;

    for(int i = 0; i < size; i++){

        for(int j = 0; j < size - 1 - i; j++){

            if(nums[j] > nums[j + 1]){

                int temp = nums[j + 1];
                nums[j + 1] = nums[j];
                nums[j] = temp;

            }

        }

    }
    return nums;
}
