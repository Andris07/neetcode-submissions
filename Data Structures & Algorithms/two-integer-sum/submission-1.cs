public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int n = nums.Length;
        int i = 0;
        int j = 1;

        while (target - nums[i] != nums[j])
        {
            if (j == n)
            {
                i++;
                j = i;
            }
            else
            {
                if (j == n-1)
                {
                    i++;
                    j = i;
                }
            }
            j++;
        }
        return new int[]{ i, j };
    }
}
