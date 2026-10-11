public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        
        int low = 1 ;
        int high = piles.Max();

        while(low<high)
        {
            int mid = low + (high-low)/2;
            long hours = 0;

            for(int i = 0; i<piles.Length; i++)
            {
                hours += (piles[i] + (long)mid - 1) / mid;


            }
            if(hours>h)
            {
                low = mid+1;
            }
            else
            {
                high = mid;
            }
        }
        return low;


    }
}
