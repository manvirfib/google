public class LargestRectangleAreaSolution
{
    public int LargestRectangleArea(int[] heights)
    {
        Stack<int> stack = new Stack<int>();
        int n = heights.Length;
        int max = 0;
        int[] leftSmaller = new int[n];
        int[] rightSmaller = new int[n];
        // NSL
        for (int i = 0; i < n; i++)
        {
            while (stack.Count > 0 && heights[stack.Peek()] >= heights[i])
            {
                stack.Pop();
            }
            if (stack.Count == 0)
            {
                leftSmaller[i] = -1;
            }
            else
            {
                leftSmaller[i] = stack.Peek();
            }
            stack.Push(i);
        }
        stack.Clear();

        // NSR
        for (int i = n - 1; i >= 0; i--)
        {
            while (stack.Count > 0 && heights[stack.Peek()] >= heights[i])
            {
                stack.Pop();
            }
            if (stack.Count == 0)
            {
                rightSmaller[i] = n;
            }
            else
            {
                rightSmaller[i] = stack.Peek();
            }
            stack.Push(i);
        }

        for (int i = 0; i < n; i++)
        {
            max = Math.Max(max, (rightSmaller[i] - leftSmaller[i] - 1) * heights[i]);
        }

        return max;
    }
}
//Finding left near smallest and right near smallest, and you will get the ans.