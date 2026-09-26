public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int len = nums.Length;
        int[] output = new int[len];

        int prefix  = 1;
        for(int i = 0 ; i < nums.Length; i++)
        {
            output[i] = prefix;
            prefix*=nums[i];
        }

        int postfix = 1;
        for(int i = len-1; i>=0; i--)
        {
            output[i]*=postfix;
            postfix*=nums[i];
        }

        return output;

    }
}
