public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int n = nums.Length;
        Dictionary<int, int> hashMap = new();

        for (int i = 0; i < n; i++)
        {
            int j = target - nums[i];
            if (hashMap.ContainsKey(j) && hashMap[j] != i)
            {
                return new int[]{ hashMap[j], i };
            }
            hashMap[nums[i]] = i;
        }
        return new int[]{ 0, 0 };
    }
}
