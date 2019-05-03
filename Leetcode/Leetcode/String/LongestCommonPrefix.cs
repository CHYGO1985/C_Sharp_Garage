using System;

/*
 * 
 * @jingjiejiang Mar 3, 2019
 */
public class Class1
{
    //public string LongestCommonPrefix(string[] strs)
    //{
    //    // find the shortest in array, then compare via using the shortest
    //    string res = "";
    //    if (strs == null || strs.Length == 0) return res;

    //    string shortStr = strs[0];
        
    //    foreach(string str in strs)
    //    {
    //        if (str.Length < shortStr.Length)
    //        {
    //            shortStr = str;
    //        }
    //    }

    //    int length = 1;

    //    while (length <= shortStr.Length)
    //    {
    //        string prefix = shortStr.Substring(0, length);
    //        foreach (string str in strs)
    //        {
    //            if (str.IndexOf(prefix) != 0) return res;
    //        }

    //        res = prefix;
    //        length++;
    //    }

    //    return res;
    //}

    public string LongestCommonPrefix(string[] strs)
    {
        string res = "";
        if (strs == null || strs.Length == 0) return res;

        string standard = strs[0];
        StringBuilder builder = new StringBuilder();

        for (int idx = 0; idx < standard.Length; idx++)
        {
            char curChar = standard[idx];
            for (int strIdx = 1; strIdx < strs.Length; strIdx++)
            {
                if (idx >= strs[strIdx].Length || strs[strIdx][idx] != curChar) return builder.ToString();
            }
            builder.Append(curChar);
        }

        return builder.ToString();
    }
}
