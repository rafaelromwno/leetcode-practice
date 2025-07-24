class QuickSort
{
    public static void QuickSort(int[] array, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(array, low, high);

            // recursively sort left and right subarrays
            QuickSort(array, low, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, high);
        }
    }

    private static int Partition(int[] array, int low, int high)
    {
        int pivot = array[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (array[j] <= pivot)
            {
                i++;
                Swap(array, i, j);
            }
        }

        Swap(array, i + 1, high);
        return i + 1;
    }

    private static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

}
