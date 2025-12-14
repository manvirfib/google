public class LongestPalindromeSolution {
    string Pal(int left, int right, string s){
        while(left >= 0 && right < s.Length && s[left] == s[right]){
            left--;
            right++;
        }
        return s.Substring(left + 1, right - left - 1);
    }
    public string LongestPalindrome(string s) {
        int n = s.Length;
        string res = "";

        for(int i = 0; i < n; i++){
            string odd = Pal(i, i, s);
            string even = Pal(i, i + 1, s);
            if(odd.Length > res.Length){
                res = odd;
            }
            if(even.Length > res.Length){
                res = even;
            }
        }

        return res;
    }
}