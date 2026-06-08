public class Solution {
    public bool hasDuplicate(int[] nums) {
        int n = nums.Length;
        Array.Sort(nums);

        for (int i = 1; i < n; i++)
        {
            if (nums[i-1] == nums[i]) return true;
        }
        return false;
    }
}