public class Solution {

    public static void Merge(int[] array, int start, int midPoint, int end)
    {
        int left_lenght = midPoint - start + 1;
        int right_lenght = end - midPoint;

        int[] left_array = new int[left_lenght];
        int[] right_array = new int[right_lenght];

        int i, j, k;

        for (i = 0; i < left_lenght; ++i)
            left_array[i] = array[start + i];

        for (i = 0; i < right_lenght; ++i)
            right_array[i] = array[midPoint + 1 + i];

        i = 0;
        j = 0;
        k = start;

        while (i < left_lenght && j < right_lenght)
        {
            if (left_array[i] < right_array[j])
                array[k] = left_array[i++];
            else
                array[k] = right_array[j++];
            ++k;
        }

        while (i < left_lenght)
        {
            array[k++] = left_array[i++];
        }
        while (j < right_lenght)
            array[k++] = right_array[j++];
    }

    public static void MergeSort(int[] array, int start, int end)
    {
        if (end <= start) return;
        int midPoint = (end + start) / 2;

        MergeSort(array, start, midPoint);
        MergeSort(array, midPoint + 1, end);
        Merge(array, start, midPoint, end);
    }

    public bool ContainsDuplicate(int[] nums) {
        MergeSort(nums, 0, nums.Length - 1);

        for (int i = 1; i < nums.Length; ++i)
        {
            if(nums[i] == nums[i-1])
                return true;
        }

        return false;
    }
}