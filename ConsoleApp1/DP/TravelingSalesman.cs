namespace HelloWorld
{
    class TravellingSalesman
    {
        bool[] selected;
        public TravellingSalesman(int[,] graph)
        {
            selected = new bool[graph.GetLength(1)];
            selected[1] = true;
            Run(1);
        }
        public void Run(int n)
        {
            for (int i = 2; i < selected.Length; i++)
            {
                if (selected[i] == false && i != n)
                {
                    selected[i] = true;
                    Run(i);
                    selected[i] = false;
                }
            }
        }
    }
}