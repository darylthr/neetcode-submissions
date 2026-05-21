public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        Dictionary<char, int> s_chars = new Dictionary<char, int>();

        // Populate Dictionary with counts
        for(int i = 0; i < s.Length; i++) {
            if (s_chars.ContainsKey(s[i])) s_chars[s[i]]++;
            else s_chars[s[i]] = 1;
        }

        foreach(char c in t) {
            if(!s_chars.ContainsKey(c) || s_chars[c] == 0) return false;
            s_chars[c]--;
        }

        return true;
    }
}