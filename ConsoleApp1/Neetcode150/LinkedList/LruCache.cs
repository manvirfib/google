public class LRUCache {
    int capacity;
    Dictionary<int, LinkedListNode<(int, int)>> cache;
    LinkedList<(int, int)> order;
    public LRUCache(int capacity) {
        this.capacity = capacity;
        cache = new Dictionary<int, LinkedListNode<(int, int)>>();
        order = new LinkedList<(int, int)>();
    }
    
    public int Get(int key) {
        if(!cache.ContainsKey(key)){
            return -1;
        }
        var node = cache[key];
        order.Remove(node);
        order.AddLast(node);

        return node.Value.Item2;
    }
    
    public void Put(int key, int value) {
        if(cache.ContainsKey(key)){
            var node = cache[key];
            order.Remove(node);
            node.Value = (key, value);
            order.AddLast(node);

            return;
        }

        if(order.Count == capacity){
            var node = order.First;
            cache.Remove(node.Value.Item1);
            order.Remove(node);
        }

        var newNode = new LinkedListNode<(int, int)>((key, value));
        cache[key] = newNode;
        order.AddLast(newNode);
    }
}
