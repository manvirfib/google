public class SlidingWindowProblem {
    public int LengthOfLongestSubstring(string s) {
        int i = 0, j = 0;
        HashSet<char> hSet = new HashSet<char>();
        int cur = 0, longest = 0;
        //set x
        // c: 1
        // l: 1

        while(j < s.Length && i <= j){
            if(hSet.Contains(s[j])){
                hSet.Remove(s[i]);
                i++;
                cur--;
            }
            else{
                hSet.Add(s[j]);
                cur++;
                j++;
            }
            
            longest = Math.Max(cur, longest);
        }

        return longest;
    }
}
