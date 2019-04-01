using System;

/**
 * 
 * @jingjiejiang Apr 1, 2019
 */
namespace Leetcode.String
{
    public class ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            // assume that s and t will not be null
            if (s.Length != t.Length) return false;
            int[] dicts = new int[26];

            for (int idx = 0; idx < s.Length; idx ++)
            {
                dicts[s[idx] - 'a'] += 1;
                dicts[t[idx] - 'a'] -= 1;
            }

            foreach (int dict in dicts)
            {
                if (dict != 0) return false;
            }

            return true;
        }
    }
}
