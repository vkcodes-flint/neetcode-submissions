public class Solution {
    public int LengthOfLongestSubstring(string s) {
            HashSet<char> res = new();
            int maxlength = 0;
            int left = 0;
            for(int right = 0; right<s.Length;right++)
            {
                while(res.Contains(s[right]))
                {
                    res.Remove(s[left]);
                     left++;
                }
                res.Add(s[right]);
                maxlength = Math.Max(maxlength, right-left+1);
            }
            return maxlength;
    }
}
