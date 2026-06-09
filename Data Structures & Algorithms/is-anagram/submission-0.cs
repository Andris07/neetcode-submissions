public class Solution {
    public bool IsAnagram(string s, string t) {
        var s_chars = s.ToCharArray();
        var t_chars = t.ToCharArray();

        Array.Sort(s_chars);
        Array.Sort(t_chars);

        return s_chars.SequenceEqual(t_chars);
    }
}
