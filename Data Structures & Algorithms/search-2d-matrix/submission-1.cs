public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        
         int rows = matrix.Length;
        int cols = matrix[0].Length;

        int low = 0;
        int high = rows * cols - 1;
            while(low<=high)
            {
                int mid = low+(high-low)/2;
                int value = matrix[mid/cols][mid%cols];
                if(value == target)
                    return true;
                if(value > target)
                {
                    high = mid-1;
                }
                else
                    low = mid+1;
            }
            return false;
        
    }
}
