public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0;
        int right = heights.Length -1;
        int highest = 0;


        while(left<right)
        {
            int min = Math.Min(heights[left], heights[right]);
            int width = right - left;
            int area = width*min;
            highest = Math.Max(highest, area);

            if(heights[left] < heights[right])
            {
                left++;
            }
            else{
                right--;
            }
        }
        return highest;
    }
}
