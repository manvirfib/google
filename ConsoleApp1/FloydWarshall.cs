class FloydWarshallAlgorithm
{
    public void FloydWarshall(int[,] dist)
    {
        int n = dist.GetLength(0);

        for (int via = 0; via < n; via++)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (dist[i, via] != int.MaxValue && dist[via, j] != int.MaxValue)
                    {
                        dist[i, j] = Math.Min(dist[i, j], dist[i, via] + dist[via, j]);
                    }
                }
            }
        }
    }
}
