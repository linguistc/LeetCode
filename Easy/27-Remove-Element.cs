public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int[] expectedNums = new int[nums.Length];
        short i =0, j = 0;
        for (; i < nums.Length; ++i)
        {
            if(nums[i] != val)
                expectedNums[j++] = nums[i];
        }

        Array.Copy(expectedNums, nums, j);

        return j;
    }
}