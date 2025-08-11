namespace HelloWorld
{
    class MaxHeap
    {
        List<int> arr = new List<int>();
        public int dIndex = 1;
        public void Insert(int val)
        {
            arr.Add(val);
            int cur = arr.Count - 1;

            while (cur > 0 && arr[cur] > arr[cur / 2])
            {
                arr[cur] = arr[cur / 2];
                cur = cur / 2;
                arr[cur] = val;
            }
        }

        public void display()
        {
            foreach (var a in arr)
            {
                Console.Write(a + " ");
            }
        }

        public int delete()
        {
            var diff = arr.Count - dIndex;
            if (diff > 1)
            {
                int temp = arr[diff];
                arr[diff] = arr[0];
                arr[0] = temp;
            }
            var cur = 0;
            var j = 2 * cur + 1;

            while (j < (diff - 1))
            {
                if (arr[j] < arr[j + 1])
                    j++;
                if (arr[j] > arr[cur])
                {
                    int temp1 = arr[j];
                    arr[j] = arr[cur];
                    arr[cur] = temp1;
                    cur = j;
                    j = 2 * cur + 1;
                }
                else
                {
                    break;
                }
            }

            dIndex++;

            return arr[diff];
        }
    }
}