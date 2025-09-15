public class TaskScheduler {
    public int LeastInterval(char[] tasks, int n) {
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>(Comparer<int>.Create((x, y)=> y.CompareTo(x)));
        Dictionary<char, int> dict = new Dictionary<char, int>();

        var queue = new Queue<(int count, int time)>();

        foreach(var task in tasks){
            dict[task] = dict.GetValueOrDefault(task, 0) + 1;
        }

        foreach(var i in dict){
            pq.Enqueue(i.Value, i.Value);
        }

        int time = 0;

        while(pq.Count > 0 || queue.Count > 0){
            while(queue.Count > 0 && queue.Peek().time <= time){
                var ele = queue.Dequeue();
                pq.Enqueue(ele.count, ele.count);
            }
            if(pq.Count > 0){
                var data = pq.Dequeue();
                time++;
                if((data - 1) > 0)
                    queue.Enqueue((data - 1, time + n));
            }
            else{
                time = queue.Peek().time;
            }
        }

        return time;
    }
}
