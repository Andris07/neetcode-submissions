public class Solution {
    public int[] SortArray(int[] nums) {
        if (nums.Length <= 1) return nums;

        int mid = nums.Length / 2;
        int[] left = nums[0..mid];
        int[] right = nums[mid..nums.Length];

        int[] leftSorted = SortArray(left);
        int[] rightSorted = SortArray(right);

        return Merge(leftSorted, rightSorted);
    }

    internal int[] Merge(int[] left, int[] right)
    {
        int l_Length = left.Length;
        int r_Length = right.Length;
        int[] result = new int[l_Length + r_Length];
        
        int idx = 0;
        int i = 0;
        int j = 0;

        while (i < left.Length && j < right.Length)
        {
            if (left[i] <= right[j])
            {
                result[idx] = left[i];
                idx++;
                i++;
            }
            else
            {
                result[idx] = right[j];
                idx++;
                j++;
            }
        }
        
        while (i < l_Length)
        {
            result[idx] = left[i];
            idx++;
            i++;
        }
        while (j < r_Length)
        {
            result[idx] = right[j];
            idx++;
            j++;
        }
        return result;
    }
}