public class Solution {
    public int[] GetConcatenation(int[] nums) {
        List<int> ans = new List<int>();
        ans.AddRange(nums); ans.AddRange(nums);
        return ans.ToArray();
    }
}