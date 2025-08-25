public class TopKFrequentElements
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        // 1. Count frequencies
        Dictionary<int, int> freq = new Dictionary<int, int>();
        int maxCount = 0;
        foreach (var num in nums)
        {
            freq[num] = freq.GetValueOrDefault(num, 0) + 1;
            maxCount = Math.Max(maxCount, freq[num]);
        }

        // 2. Create buckets: index = frequency
        List<int>[] buckets = new List<int>[maxCount + 1];
        foreach (var kvp in freq)
        {
            int num = kvp.Key, count = kvp.Value;
            if (buckets[count] == null)
                buckets[count] = new List<int>();
            buckets[count].Add(num);
        }

        // 3. Collect top k elements from highest frequency bucket
        List<int> result = new List<int>(k);
        for (int i = maxCount; i >= 0 && result.Count < k; i--)
        {
            if (buckets[i] != null)
            {
                foreach (var num in buckets[i])
                {
                    result.Add(num);
                    if (result.Count == k) break;
                }
            }
        }

        return result.ToArray();
    }
}

//Use BucketSort
//Array of List<int> :)
