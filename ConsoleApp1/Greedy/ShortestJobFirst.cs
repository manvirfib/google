public class SJFSolution {
    public long solve(List<int> bt) {
        bt.Sort();
        int waitTime = 0;
        int n = bt.Count;
        
        for(int i = 0; i < n; i++){
            waitTime += bt[i] * (n - i - 1);
        }
        
        return waitTime/n;
    }
}