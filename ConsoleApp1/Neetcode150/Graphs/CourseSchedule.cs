public class CourseSchedule
{
    public bool CanFinish(int v, int[][] pre)
    {
        int m = pre.Length;
        List<int>[] adj = new List<int>[v];

        for (int i = 0; i < v; i++)
        {
            adj[i] = new List<int>();
        }

        for (int i = 0; i < m; i++)
        {
            adj[pre[i][1]].Add(pre[i][0]);
        }

        int[] degree = new int[v];

        for (int i = 0; i < v; i++)
        {
            var list = adj[i];
            for (int j = 0; j < list.Count; j++)
            {
                degree[list[j]]++;
            }
        }

        Queue<int> queue = new Queue<int>();

        for (int i = 0; i < v; i++)
        {
            if (degree[i] == 0)
            {
                queue.Enqueue(i);
            }
        }

        int count = 0;

        while (queue.Count > 0)
        {
            var value = queue.Dequeue();
            count++;
            var list = adj[value];
            for (int i = 0; i < list.Count; i++)
            {
                degree[list[i]]--;
                if (degree[list[i]] == 0)
                {
                    queue.Enqueue(list[i]);
                }
            }
        }

        return count == v;
    }
}

// Kahn's Algorithm.
// In order to find the topological sort.