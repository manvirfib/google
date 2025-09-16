public class PartitionProblem {
    bool IsP(string s){
        int i = 0, j = s.Length - 1;

        while(i < j){
            if(s[i] != s[j])
            return false;
            i++;
            j--;
        }

        return true;
    }
    void partition(int cur, string s, List<string> ds, List<List<string>> result){
        if(cur == s.Length){
            result.Add(new List<string>(ds));
            return;
        }
        for(int i = 1; i <= s.Length - cur; i++){
            string str = s.Substring(cur, i);
            if(IsP(str)){
                ds.Add(str);
                partition(cur + i, s, ds, result);
                ds.RemoveAt(ds.Count - 1);
            }
        }
    }
    public List<List<string>> Partition(string s) {
        var result = new List<List<string>>();

        partition(0, s, new List<string>(), result);

        return result;
    }
}
