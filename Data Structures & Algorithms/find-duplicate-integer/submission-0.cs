public class Solution {
    public int FindDuplicate(int[] nums) {

        int slow = 0, fast = 0;
        while(true)
        {
            slow = nums[slow];
            fast = nums[nums[fast]];

            if(fast == slow)
                break;
        }

        int slowsec = 0;
        while(slow != slowsec)
        {
            slow = nums[slow];
            slowsec = nums[slowsec];
        }
        return slow;
    }
}
