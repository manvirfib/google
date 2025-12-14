public class CountSubstringsSolution {
    int Pal(int left, int right, string s){
        int count = 0;
        while(left >= 0 && right < s.Length && s[left] == s[right]){
            left--;
            right++;
            count++;
        }
        return count;
    }
    public int CountSubstrings(string s) {
        int n = s.Length;
        int res = 0;

        for(int i = 0; i < n; i++){
            int odd = Pal(i, i, s);
            int even = Pal(i, i + 1, s);
            res = res + odd + even;
        }

        return res;
    }
}
