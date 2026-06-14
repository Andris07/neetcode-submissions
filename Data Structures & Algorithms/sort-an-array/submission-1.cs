public class Solution {
    public int[] SortArray(int[] nums) {
        SortArray(nums, 0, nums.Length - 1);
        return nums;
    }

    public void SortArray(int[] nums, int from, int to) {
        if(from >= to) return;

        int pivotIndex = Random.Shared.Next(from, to + 1);
        int pivot = nums[pivotIndex];

        int i = from;
        int j = from;
        int k = to;

        while(j <= k)
        {
            int n = nums[j];
            if (n == pivot)
            {

                j++;
                continue;
            }
            if (n < pivot)
            {

                nums[j] = nums[i];
                nums[i] = n;

                i++;
                j++;
                continue;
            }

            nums[j] = nums[k];
            nums[k] = n;
            
            k--;
        }
        SortArray(nums, from, i - 1);
        SortArray(nums, j, to);
    }
}