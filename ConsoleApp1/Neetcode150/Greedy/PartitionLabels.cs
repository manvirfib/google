public class PartitionLabelsSolution {
    public List<int> PartitionLabels(string s) {
        int n = s.Length;
        int[] count = new int[26];
        for(int i = 0; i < n; i++){
            count[s[i]-'a'] = i;
        }
        int start = 0, end = 0;
        List<int> res = new();

        for(int i = 0; i < n; i++){
            end = Math.Max(end, count[s[i]-'a']);
            if(i == end){
                res.Add(end - start + 1);
                start = i + 1;
            }
        }

        return res;
    }
}
