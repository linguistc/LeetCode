public class Solution {
   public bool IsAnagram(string s, string t)
    {
        // Not anagram if not the same length.
        if (s.Length !=  t.Length) return false;

        char[] sChars = s.ToCharArray();
        char[] tChars = t.ToCharArray();

        MergeSort(sChars, 0, sChars.Length - 1);
        MergeSort(tChars, 0, tChars.Length - 1);

        for (int i = 0; i < sChars.Length; ++i)
        {
            if (sChars[i] != tChars[i]) return false;
        }

        return true;
    }


    public static void Merge(char[] array, int start, int midPoint, int end)
    {
        int left_lenght = midPoint - start + 1;
        int right_lenght = end - midPoint;

        char[] left_array = new char[left_lenght];
        char[] right_array = new char[right_lenght];

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

    public static void MergeSort(char[] array, int start, int end)
    {
        if (end <= start) return;
        int midPoint = (end + start) / 2;

        MergeSort(array, start, midPoint);
        MergeSort(array, midPoint + 1, end);
        Merge(array, start, midPoint, end);
    }
}