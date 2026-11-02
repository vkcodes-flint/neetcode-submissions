public class Solution {


    private void Backtrack(
        int index,
        int[] nums,
        List<int> current,
        List<List<int>> result)
    {
        // Add current subset
        result.Add(new List<int>(current));

        // Explore remaining elements
        for (int i = index; i < nums.Length; i++)
        {
            // Choose
            current.Add(nums[i]);

            // Explore
            Backtrack(i + 1, nums, current, result);

            // Backtrack
            current.RemoveAt(current.Count - 1);
        }
    }
    public List<List<int>> Subsets(int[] nums) {
         List<List<int>> result = new List<List<int>>();
        List<int> current = new List<int>();

        Backtrack(0, nums, current, result);

        return result;
    }
}
