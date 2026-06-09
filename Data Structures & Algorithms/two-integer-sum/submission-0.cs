public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int n = nums.Length;

        for (int i = 0; i < n; i++)
        {
            for (int j = i+1; j < n; j++)
            {
                if (target - nums[i] == nums[j]) return new int[]{ i, j };
            }
        }
        return new int[]{ 0, 0 };
    }
}
