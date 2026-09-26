public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> output = new();
        foreach(var ele in strs)
        {
            int[] count = new int[26];
            for(int i = 0; i< ele.Length; i++)
            {
                count[ele[i] - 'a']++;
            }
            var data = String.Join(',', count);
            if(!output.ContainsKey(data))
            {
                  output[data] = new List<string>();  
            }
            output[data].Add(ele);

        }

        return new List<List<string>>(output.Values);
    }
}
