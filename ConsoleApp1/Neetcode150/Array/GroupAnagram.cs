public class GroupAnagram
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
        foreach (var word in strs)
        {
            int[] count = new int[26];
            foreach (var character in word)
            {
                count[character - 'a'] += 1;
            }

            string key = string.Join("#", count);

            if (!dict.ContainsKey(key))
            {
                dict[key] = new List<string>();
            }

            dict[key].Add(word);
        }

        return [.. dict.Values];
    }
}

/*
For each word, the sort is taking only O(n) -- Count Sort :)
*/

