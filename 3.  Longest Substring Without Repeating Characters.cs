public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (string.IsNullOrEmpty(s)) return 0;

        Dictionary<char, int> map = new Dictionary<char, int>();
        int left = 0, maxLength = 0;

        for (int right = 0; right < s.Length; right++) {
            char c = s[right];

            if (map.ContainsKey(c) && map[c] >= left) {
                left = map[c] + 1; // Move left pointer after the last duplicate
            }

            map[c] = right; // Update latest index of character
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}
