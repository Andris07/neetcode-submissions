public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int n = nums.Length;
        int i = 0;
        int j = 1;

        while (i < n - 1)
        {
            if (j >= n)
            {
                i++;
                j = i + 1;
                continue;
            }

            if (nums[i] + nums[j] == target)
            {
                break;
            }
            j++;
        }
        return new int[] { i, j };
    }
}
