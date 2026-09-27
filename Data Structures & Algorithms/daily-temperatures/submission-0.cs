public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        
        int[] res = new int[temperatures.Length];
        Stack<int[]> stack = new();

        for(int i = 0; i < temperatures.Length; i++)
        {
            int cur = temperatures[i];
            while(stack.Count > 0 && cur > stack.Peek()[1])
            {
                int[] prev = stack.Pop();
                int previndex = prev[0];

                res[previndex] = i-previndex;
            }

            stack.Push(new int[]{i,temperatures[i]});
        }

        return res;
    }
}
