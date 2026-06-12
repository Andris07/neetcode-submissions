public class Solution {
    public void SortColors(int[] nums) {
        int n = nums.Length;
        int red = 0;
        int white = 0;

        for (int i = 0; i < n; i++)
        {
            if (nums[i] == 0) red++;
            else if (nums[i] == 1) white++;
        }

        for (int i = 0; i < n; i++)
        {
            if (red > 0)
            {
                nums[i] = 0;
                red--;
            }
            else if (white > 0)
            {
                nums[i] = 1;
                white--;
            }
            else nums[i] = 2;
        }
    }
}