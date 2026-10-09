public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        
        if(s1.Length > s2.Length)
            return false;

        int[] target = new int[26];
        int[] window = new int[26];

        foreach(var c in s1)
        {
            target[c - 'a']++;
        }

        for(int right = 0; right<s2.Length ; right++)
        {
            window[s2[right] - 'a']++;

            if(right >= s1.Length)
            {
                window[s2[right-s1.Length] - 'a']--;
            }

            if (target.SequenceEqual(window))
                return true;
        }
        return false;
    }
}
