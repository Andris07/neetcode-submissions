public class Solution {
    public int MajorityElement(int[] nums) {
        int candidate = nums[0];
        int count = 1;
        int i = 1;

        while (i < nums.Length)
        {
            if (count == 0)
            {
                candidate = nums[i];
                count = 1;
            }
            else if (nums[i] == candidate)
            {
                count++;
            }
            else count--;

            i++;
        }
        return candidate;
    }
}