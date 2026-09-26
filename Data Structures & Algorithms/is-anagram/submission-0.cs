public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;

        int[] count = new int[26];

        for(int i = 0;i < s.Length; i++)
        {
            count[s[i] - 'a']++;
            count[t[i]-'a']--;
        }

        foreach(var ele in count)
        {
            if(ele != 0)
            {
                return false;
            }
        }
        return true;

    }
}
