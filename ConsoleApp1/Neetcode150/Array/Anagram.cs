class Anagram {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        Dictionary<char, int> dict = new Dictionary<char, int>();

        foreach (var ch in s) {
            dict[ch] = dict.GetValueOrDefault(ch, 0) + 1;
        }

        foreach (var ch in t) {
            if (!dict.ContainsKey(ch)) return false;

            dict[ch]--;
            if (dict[ch] == 0) dict.Remove(ch);
        }

        return dict.Count == 0;
    }
}