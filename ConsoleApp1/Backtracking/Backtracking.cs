namespace HelloWorld
{
    class Backtracking
    {
        bool[] arr;
        string input;
        char[] result;
        public Backtracking(string input)
        {
            this.input = input;
            arr = new bool[input.Length];
            result = new char[input.Length];
            Run(0);
        }
        void Run(int k)
        {
            if (k == input.Length)
            {
                Console.WriteLine(new string(result));
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == false)
                {
                    result[k] = input[i];
                    arr[i] = true;
                    Run(k + 1);
                    arr[i] = false;
                } 
            }

        }
    }
}