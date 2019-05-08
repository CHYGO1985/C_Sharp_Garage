using System;

/*
 * 
 * @jingjiejiang May 8, 2019
 */ 
public class Class1
{
    public int StrStr(string haystack, string needle)
    {
        if (needle == null || needle.Length == 0) return 0;

        int[] next = getNextArr(needle);

        int heystackIdx = 0;
        int needleIdx = 0;

        while (heystackIdx < haystack.Length)
        {
            if (needleIdx == -1 || needle[needleIdx] == haystack[heystackIdx])
            {
                needleIdx++;
                heystackIdx++;
            }
            else
            {
                needleIdx = next[needleIdx];
            }

            if (needleIdx == needle.Length) return heystackIdx - needleIdx;
        }

        return -1;
    }

    private int[] getNextArr(string needle)
    {
        int[] next = new int[needle.Length];

        int prefix = -1, suffix = 0;
        next[suffix] = prefix;

        while (suffix < needle.Length - 1)
        {
            if (prefix == -1 || needle[suffix] == needle[prefix])
            {
                next[++suffix] = ++prefix;
            }
            else
            {
                prefix = next[prefix];
            }
        }

        return next;
    }
}
