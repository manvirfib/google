public class IsNStraightHandSolution {
    public bool IsNStraightHand(int[] hand, int gs) {
        Dictionary<int, int> dict = new();
        int n = hand.Length;
        if(n % gs != 0) return false;

        for(int i = 0; i < n; i++){
            dict[hand[i]] = dict.GetValueOrDefault(hand[i], 0) + 1;
        }

        int[] count = new int[dict.Count];
        int k = 0;

        foreach(var key in dict.Keys){
            count[k++] = key;
        }

        Array.Sort(count);

        for(int i = 0; i < count.Length; i++){
            int key = count[i];
            int startCount = dict[key];
            if(startCount <= 0) continue;
            for(int j = key; j < key + gs; j++){
                if(dict.GetValueOrDefault(j, 0) < startCount) return false;
                dict[j] = dict[j] - startCount;
            }
        }

        return true;
    }
}