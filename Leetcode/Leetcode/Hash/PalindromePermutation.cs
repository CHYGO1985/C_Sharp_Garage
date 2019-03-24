using System;
using System.Collections;

/*
 * 
 *  @jingjie jiang Mar 24, 2019
 *
 */
namespace Leetcode.Hash
{
    public class PalindromePermutation
    {
        public bool CanPermutePalindrome(string s)
        {
            Hashtable hashtable = new Hashtable();
            int oddCount = 0;

            foreach (char tmp in s)
            {
                if (hashtable.ContainsKey(tmp))
                    hashtable[tmp] = (int)hashtable[tmp] + 1;
                else
                    hashtable.Add(tmp, 1);
            }

            foreach (DictionaryEntry entry in hashtable)
                if ((int)entry.Value % 2 != 0) oddCount++;

            return oddCount < 2;
        }
    }
}
