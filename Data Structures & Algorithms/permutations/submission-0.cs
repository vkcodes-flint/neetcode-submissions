public class Solution {


    private void Swap(int[] nums, int i, int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
    public void backtrack(int[] nums, int idx, List<List<int>> result)
    {
        if(idx == nums.Length)
        {
            result.Add(new List<int>(nums));
            return;
        }
        for (int i = idx; i < nums.Length; i++)
        {
            // Choose: swap
            Swap(nums, idx, i);

            // Explore
            backtrack(nums, idx+1, result);

            // Backtrack: restore original array
            Swap(nums, idx, i);
        }
    }

    public List<List<int>> Permute(int[] nums) {
        List<List<int>> res = new();
        backtrack(nums, 0, res);
        return res;
    }
}
