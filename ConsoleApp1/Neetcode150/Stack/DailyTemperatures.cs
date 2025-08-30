public class DailyTemperaturesSolution {
    public int[] DailyTemperatures(int[] temp) {
        int n = temp.Length;
        int[] result = new int[n];
        Stack<int> stack = new Stack<int>(); // store indices only

        for (int i = n - 1; i >= 0; i--) {
            while (stack.Count > 0 && temp[i] >= temp[stack.Peek()]) {
                stack.Pop();
            }

            result[i] = stack.Count == 0 ? 0 : stack.Peek() - i;

            stack.Push(i);
        }

        return result;
    }
}
