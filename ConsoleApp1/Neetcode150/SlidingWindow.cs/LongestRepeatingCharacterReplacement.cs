public class LongestRepeatingCharacterReplacement {
    public int CharacterReplacement(string s, int k) {
        Dictionary<char, int> dict = new Dictionary<char, int>();

        int i = 0, j = 0;
        int result = 0;
        while(j < s.Length){
            dict[s[j]] = dict.GetValueOrDefault(s[j], 0) + 1;
            int num = dict.Values.Max();
            int len = j - i + 1;
            if((len - num) <= k){
                result = Math.Max(len, result);
                j++;
            }
            else{
                dict[s[i]] = dict[s[i]] - 1;
                i++;
                j++;
            }
        }

        return result;
    }
}
