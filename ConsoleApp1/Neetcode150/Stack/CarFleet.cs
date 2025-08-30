public class CarFleetSolution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int n = position.Length;
        int[][] pair = new int[n][];
        int count = 1;
        for (int i = 0; i < n; i++) {
            pair[i] = new int[] { position[i], speed[i] };
        }
        Array.Sort(pair, (a, b) => b[0].CompareTo(a[0]));
        int pos = pair[0][0];
        int s = pair[0][1];
        for(int i = 1; i < position.Length; i++){
            double time = (target - pair[i][0])/(double)pair[i][1];
            double prevTime = (target - pos)/(double)s;
            if(time > prevTime){
                count++;
                pos = pair[i][0];
                s = pair[i][1];
            }
        }

        return count;
    }
}

//Both are same: Time Complexity O(nlogn)
/*
public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int[][] pair = new int[position.Length][];
        for (int i = 0; i < position.Length; i++) {
            pair[i] = new int[] { position[i], speed[i] };
        }
        Array.Sort(pair, (a, b) => b[0].CompareTo(a[0]));
        Stack<double> stack = new Stack<double>();
        foreach (var p in pair) {
            stack.Push((double)(target - p[0]) / p[1]);
            if (stack.Count >= 2 && stack.Peek() <= stack.ElementAt(1)) {
                stack.Pop();
            }
        }
        return stack.Count;
    }
}
*/