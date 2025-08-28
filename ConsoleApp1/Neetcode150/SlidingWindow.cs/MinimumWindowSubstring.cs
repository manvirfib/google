public class MinimumWindowSubstring {
    public string MinWindow(string s, string t) {
        int l = 0, r = 0, minLength = int.MaxValue, startIndex = -1, count = 0;
        int[] dict = new int[256];

        foreach(var c in t){
            dict[c]++; 
        }

        while(r < s.Length){
            if(dict[s[r]] > 0)
            count++;
            dict[s[r]]--;
            while(count == t.Length){
                if(minLength > (r - l + 1)){
                    startIndex = l;
                    minLength = r - l + 1;
                }
                dict[s[l]]++;
                if(dict[s[l]] > 0){
                    count--;
                }
                l++;
            }
            r++;
        }

        return startIndex == -1 ? "" : s.Substring(startIndex, minLength);
    }
}
