// User function Template for C#

class Solution1
{
    void dfs(int idx, int[] arr, int sum, List<int> result)
    {
        result.Add(sum);

        for (int i = idx; i < arr.Length; i++)
        {
            dfs(i + 1, arr, sum + arr[i], result);
        }
    }
    // Function to find the sum of all possible subsets of the given array.
    public List<int> subsetSums(int[] arr)
    {
        var result = new List<int>();
        // code here
        dfs(0, arr, 0, result);

        return result;
    }
}

// User function Template for C#

class Solution2 {
    void dfs(int idx, int[] arr, int sum, List<int> result){
        if(idx >= arr.Length){
            result.Add(sum);
            return;
        }
        
        dfs(idx + 1, arr, sum + arr[idx], result);
        dfs(idx + 1, arr, sum, result);
    }
    // Function to find the sum of all possible subsets of the given array.
    public List<int> subsetSums(int[] arr) {
        var result = new List<int>();
        // code here
        dfs(0, arr, 0, result);
        
        return result;
    }
}