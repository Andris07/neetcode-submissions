public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        Array.Sort(strs);
        string first = strs[0];
        string last = strs[^1];
        int idx = 0;
                                                        
        if (first.Length == 0) return "";
        while (idx < first.Length && idx < last.Length)
        {
            if (first[idx] == last[idx]) idx++;
            else break;
        }
                                                                                                                        
        return first.Substring(0, idx);
    }
}