public class Solution {
    public int RemoveElement(int[] nums, int val) {
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val) nums[i] = 51;
        }
        Array.Sort(nums);
        return nums.Count(x => x != 51);
    }
}