public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] res = new int[26];
        int left = 0;
        int maxfreq = 0;
        int maxlength = 0;

        for(int right = 0; right < s.Length; right++)
        {
            res[s[right] - 'A']++;

            maxfreq = Math.Max(maxfreq, res[s[right]-'A']);
            while((right-left +1 ) -maxfreq >k)
            {
                res[s[left] - 'A']--;
                left++;
            }

            maxlength = Math.Max(maxlength ,  right-left+1);


        }
        return maxlength;

    }
}
