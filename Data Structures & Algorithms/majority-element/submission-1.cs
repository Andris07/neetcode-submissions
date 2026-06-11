public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> counts = new();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!counts.ContainsKey(nums[i])) counts.Add(nums[i], 0);
            counts[nums[i]]++;
        }
        return counts.MaxBy(kvp => kvp.Value).Key;
    }
}