using System;

/*
 * @jingjiejiang Mar 2, 2019
 */ 
public class Class1
{
    public bool WordPattern(string pattern, string str)
    {
        if (pattern == null) return false;

        string[] words = str.Split(" ");

        if (pattern.Length != words.Length) return false;

        Dictionary<string, char> wordMap = new Dictionary<string, char>();

        for (int idx = 0; idx < words.Length; idx ++)
        {
            char curVal = pattern[idx];
            if ( (wordMap.ContainsKey(words[idx]) && wordMap[words[idx]] != pattern[idx])
                || (wordMap.ContainsValue(curVal) && wordMap.FirstOrDefault(x => x.Value == curVal).Key != words[idx]) ) return false;
            if (wordMap.TryGetValue(words[idx], out curVal) == false) wordMap.Add(words[idx], pattern[idx]);
        }

        return true;
    }
}
