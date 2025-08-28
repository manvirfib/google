public class MinStack {
    LinkedList<int> stack, stackMin;
    public MinStack() {
        stack = new LinkedList<int>();
        stackMin = new LinkedList<int>();
    }
    
    public void Push(int val) {
        stack.AddFirst(val);
        stackMin.AddFirst(stackMin.Count == 0 ? val : Math.Min(stackMin.First(), val));
    }
    
    public void Pop() {
        stack.RemoveFirst();
        stackMin.RemoveFirst();
    }
    
    public int Top() {
        return stack.First();
    }
    
    public int GetMin() {
        return stackMin.First();
    }
}
