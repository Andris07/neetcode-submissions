public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        int length = strs.Length;
        if (length == 0 || length == 1) return new List<List<string>> { new List<string> { length == 0 ? "" : strs[0] } };

        Dictionary<string, List<string>> anagramGroups = new();

        foreach (string str in strs)
        {
            string key = new string(str.OrderBy(x => x).ToArray());
            if (!anagramGroups.ContainsKey(key))
            {
                anagramGroups[key] = new List<string>();
            }
            anagramGroups[key].Add(str);
        }

        List<List<string>> anagramGroupsList = new List<List<string>>();
        foreach (KeyValuePair<string, List<string>> pair in anagramGroups)
        {
            anagramGroupsList.Add(pair.Value);
        }
        return anagramGroupsList;
    }
}