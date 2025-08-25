public class ValidPalindrome {
    public bool IsPalindrome(string s) {
        for(int i = 0, j = s.Length - 1; i < j;){
            if(!Char.IsLetterOrDigit(s[i])){
                i++;
                continue;
            }
            if(!Char.IsLetterOrDigit(s[j])){
                j--;
                continue;
            }
            if(Char.ToLower(s[i]) != Char.ToLower(s[j]))
            return false;
            i++;
            j--;
        }

        return true;
    }
}
