public int[] SortArray(int[] nums) {
    int size = nums.Length;
    bool swapped;

    for (int i = 0; i < size; i++) {
        swapped = false;
      
        for (int j = 0; j < size - 1 - i; j++) {
            if (nums[j] > nums[j + 1]) {
                int temp = nums[j + 1];
                nums[j + 1] = nums[j];
                nums[j] = temp;
                swapped = true;
            }
        }

        if (!swapped) break; // lista já está ordenada
    }

    return nums;
}
