namespace HelloWorld
{
    class Dijkstra
    {
        int[,] arr;
        int[] distance;
        bool[] selected;
        int len = 0;
        public Dijkstra(int[,] arr)
        {
            this.arr = arr;
            len = arr.GetLength(0);
            selected = new bool[len + 1];
            distance = new int[len];
        }
        public void GetMinimumDistanceFromSource(int source)
        {
            //Source point set
            selected[source] = true;
            for (int j = 1; j < len; j++)
            {
                if (arr[source, j] >= 0)
                {
                    distance[j] = arr[source, j];
                }
                else
                {
                    distance[j] = int.MaxValue;
                }
            }
            //end

            int count = 0;

            while (count < len)
            {
                //Finding
                int min = int.MaxValue;
                int u = 0;
                for (int j = 1; j < len; j++)
                {
                    if (distance[j] < min && selected[j] == false)
                    {
                        min = distance[j];
                        u = j;
                    }
                }

                selected[u] = true;

                //Do relaxation of u (means update the connected edges distance of u)
                for (int v = 1; v < len; v++)
                {
                    if (arr[u, v] >= 0 && distance[v] > (distance[u] + arr[u, v]))
                    {
                        distance[v] = distance[u] + arr[u, v];
                    }
                }
                count++;
            }

            Console.WriteLine("********************Distances********************");
            for (int i = 1; i < len; i++)
            {
                Console.WriteLine(distance[i]);
            }
            Console.WriteLine("********************Distances********************");
        }
    }
}