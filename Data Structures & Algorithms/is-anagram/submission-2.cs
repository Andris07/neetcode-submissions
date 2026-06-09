public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        int[] arr = new int[26]; // 26 => count of lowercase English letters

        for (int i = 0; i < s.Length; i++)
        {
            arr[s[i] - 'a']++;
            arr[t[i] - 'a']--;
            // if s[i] is equal to t[i], their difference is also 0, so if their difference is not 0, then s[i] and t[i] are also not equal
        }

        for (int i = 0; i < 26; i++) // 26 => count of arr size
        {
            if (arr[i] != 0) return false;
        }
        return true;
    }
}
