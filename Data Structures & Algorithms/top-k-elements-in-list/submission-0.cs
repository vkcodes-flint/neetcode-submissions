public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        int[] result = new int[k];
        Dictionary<int,int> output = new();
        for(int i = 0;i<nums.Length;i++)
        {
            int key = nums[i];
            if(!output.ContainsKey(key))
            {
                output[key] = 1;
            }
            output[key]++;
        }

        return output
            .OrderByDescending(x => x.Value)
            .Take(k)
            .Select(x => x.Key)
            .ToArray();
    }
}
