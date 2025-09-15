public class MedianFinder {
    PriorityQueue<int, int> low;
    PriorityQueue<int, int> high;
    public MedianFinder() {
        low = new PriorityQueue<int, int>(Comparer<int>.Create(
            (x, y) => y.CompareTo(x)
        ));
        high = new PriorityQueue<int, int>();
    }
    
    public void AddNum(int num) {
        low.Enqueue(num, num);
        if (high.Count > 0 && low.Peek() > high.Peek()) {
            int move = low.Dequeue();
            high.Enqueue(move, move);
        }
        if((low.Count-high.Count) >= 2){
            var numb = low.Dequeue();
            high.Enqueue(numb, numb);
        }
        else if((high.Count - low.Count) >= 2){
            var numb = high.Dequeue();
            low.Enqueue(numb, numb);
        }
    }
    
    public double FindMedian() {
        if(low.Count != high.Count){
            if(low.Count > high.Count){
                return low.Peek();
            }
            return high.Peek();
        }
        else{
            return ((double)low.Peek() + high.Peek())/2.0;
        }
    }
}
