public class Solution {
    public bool hasDuplicate(int[] nums) {
        int n = nums.Length;
        HashSet<int> hs = new HashSet<int>();

        for (int i = 0; i < n; i++)
        {
            if (!hs.Add(nums[i]))
            {
                return true;
            }
            hs.Add(nums[i]);
        }
        return false;
    }
}