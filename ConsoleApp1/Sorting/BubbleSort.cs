namespace HelloWorld
{
    class BubbleSort
    {
        public void Sort(int[] arr)
        {
            int n = arr.Length;
            bool flag = false;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        flag = true;
                    }
                }
                // Doing this in order to make bubble sort adaptive i.e, if array is already
                // sorted then time complexity : O(n)
                if (flag == false)
                {
                    break;
                }
            }
        }
    }
}

//Bubble sort is adaptive and stable(for duplicate values it maintains the order of insertion)