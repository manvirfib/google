public class FractionalKnapsackSolution {
    public double FractionalKnapsack(int[] val, int[] wt, int capacity) {
        // code here
        List<Item> list = new();
        int n = val.Length;
        for(int i = 0; i < n; i++){
            list.Add(new Item(){
                wt = wt[i], val = val[i], ratio = (double)val[i]/wt[i]
            });
        }
        list.Sort((a, b) => b.ratio.CompareTo(a.ratio));
        double totalValue = 0;

        foreach (var item in list) {
            if (capacity == 0) break;
    
            if (item.wt <= capacity) {
                capacity -= item.wt;
                totalValue += item.val;
            } else {
                totalValue += item.ratio * capacity;
                capacity = 0;
            }
        }
    
        return totalValue;
    }
}
public class Item{
    public int wt;
    public int val;
    public double ratio;
}