public class GasStationSolution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int start = 0;
        int cur = 0;
        int n = gas.Length;
        int totGas = 0, totCost = 0;

        for(int i = 0; i < n; i++){
            totGas += gas[i];
            totCost += cost[i];
        }

        if(totGas < totCost) return -1;

        for(int i = 0; i < cost.Length; i++){
            cur += gas[i] - cost[i];
            if(cur < 0){
                start = i + 1;
                cur = 0;
            }
        }
        return start;
    }
}