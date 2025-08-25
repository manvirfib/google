public class LongestConsecutiveSequence {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> hs = new HashSet<int>();
        int longest = 0;
        int cons = 1;

        if(nums.Length == 0) return 0;

        foreach(int i in nums){
            hs.Add(i);
        }

        foreach(int i in hs){
            if(hs.Contains(i-1) || !hs.Contains(i+1))
            continue;
            int j = i;
            while(hs.Contains(j+1)){
                cons++;
                j++;
            }

            longest = Math.Max(longest, cons);
            cons = 1;
        }

        longest = Math.Max(longest, cons);

        return longest;
    }
}
